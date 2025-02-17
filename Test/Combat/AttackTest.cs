using System.Collections.Generic;
using System.Threading.Tasks;
using Doug;
using Doug.Items;
using Doug.Models;
using Doug.Repositories;
using Doug.Services;
using Doug.Slack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Test.Combat
{
    [TestClass]
    public class AttackTest
    {
        private const string Channel = "coco-channel";

        private readonly User _user = new User {Energy = 10};
        private readonly User _target = new User { Id = "robert", Credits = 10 };

        private CombatService _combatService;

        private readonly Mock<IUserRepository> _userRepository = new Mock<IUserRepository>();
        private readonly Mock<ISlackWebApi> _slack = new Mock<ISlackWebApi>();
        private readonly Mock<IEventDispatcher> _itemEventDispatcher = new Mock<IEventDispatcher>();
        private readonly Mock<IStatsRepository> _statsRepository = new Mock<IStatsRepository>();
        private readonly Mock<IRandomService> _randomService = new Mock<IRandomService>();
        private readonly Mock<IUserService> _userService = new Mock<IUserService>();
        private readonly Mock<IChannelRepository> _channelRepository = new Mock<IChannelRepository>();
        private readonly Mock<IMonsterRepository> _monsterRepository = new Mock<IMonsterRepository>();
        private readonly Mock<IMonsterService> _monsterService = new Mock<IMonsterService>();

        [TestInitialize]
        public void Setup()
        {
            _userService.Setup(service => service.IsUserActive(It.IsAny<string>())).Returns(Task.FromResult(true));
            _slack.Setup(slack => slack.GetUsersInChannel("coco-channel")).Returns(Task.FromResult(new List<string> {"robert"}));
            _channelRepository.Setup(repo => repo.GetChannelType("coco-channel")).Returns(ChannelType.Pvp);
            _itemEventDispatcher.Setup(disp => disp.OnStealingAmount(It.IsAny<User>(), It.IsAny<int>())).Returns(1);

            _combatService = new CombatService(_itemEventDispatcher.Object, _userRepository.Object, _slack.Object, _statsRepository.Object, _randomService.Object, _userService.Object, _channelRepository.Object, _monsterRepository.Object, _monsterService.Object);
        }

        [TestMethod]
        public async Task WhenAttacking_HealthIsRemovedFromTheTarget()
        {
            await _combatService.Attack(_user, _target, Channel);

            _statsRepository.Verify(repo => repo.UpdateHealth(_target.Id, It.IsAny<int>()));
        }

        [TestMethod]
        public async Task GivenUserHasNoEnergy_WhenAttacking_NotEnoughEnergyMessage()
        {
            var user = new User { Energy = 0 };

            var result = await _combatService.Attack(user, _target, Channel);

            Assert.AreEqual(DougMessages.NotEnoughEnergy, result.Message);
        }

        [TestMethod]
        public async Task GivenUserIsInWrongChannel_WhenAttacking_WrongChannelMessage()
        {
            _channelRepository.Setup(repo => repo.GetChannelType("coco-channel")).Returns(ChannelType.Common);

            var result = await _combatService.Attack(_user, _target, Channel);

            Assert.AreEqual(DougMessages.NotInRightChannel, result.Message);
        }

        [TestMethod]
        public async Task GivenTargetIsNotInPvp_WhenAttacking_TargetNotInPvpMessage()
        {
            _slack.Setup(slack => slack.GetUsersInChannel("coco-channel")).Returns(Task.FromResult(new List<string> { "not robert" }));

            var result = await _combatService.Attack(_user, _target, Channel);

            Assert.AreEqual(DougMessages.UserIsNotInPvp, result.Message);
        }

    }
}
