﻿namespace Doug
{
    public static class DougMessages
    {
        public const string CoffeeParrotEmoji = ":coffeeparrot:";
        public const string CreditEmoji = ":rupee:";
        public const string UpVote = "+1";
        public const string Downvote = "-1";

        public const string Top5 = "Top users by level :";
        public const string JoinedCoffee = "{0} joined the coffee break.";
        public const string KickedCoffee = "{0} was kicked from the coffee break.";
        public const string SkippedCoffee = "{0} will skip the coffee break.";
        public const string Remind = "*{0}/{1}* - {2}";
        public const string Remind69 = "*{0}/{1}* - YEAH - {2}";
        public const string CoffeeStart = "Alright, let's do this. <!here> GO!";
        public const string BackToWork = "<!here> Go back to work, ya bunch o' lazy dogs!";
        public const string GainedCredit = "You gained {0} " + CreditEmoji;
        public const string SlursCleaned = "The following slurs have been cleaned up";
        public const string SlurCreatedBy = "{0} created that slur.";
        public const string Balance = "You have {0} " + CreditEmoji;
        public const string UserGaveCredits = "{0} gave {1} " + CreditEmoji + " to {2}";
        public const string StatsOf = "Profile and stats of {0}";
        public const string CreditStats = CreditEmoji + " {0}";
        public const string LevelStats = "Level {0}";
        public const string ExperienceStats = "{0:0.##}%";
        public const string HealthStats = ":hp: Health : {0}";
        public const string EnergyStats = ":mp: Mana : {0}";
        public const string StrengthStats = ":information_desk_person: Strength : {0}";
        public const string AgilityStats = ":runner: Agility : {0}";
        public const string LuckStats = ":four_leaf_clover: Luck : {0}";
        public const string ConstitutionStats = ":heart: Constitution : {0}";
        public const string IntelligenceStats = ":male_mage: Intelligence : {0}";
        public const string FreeStatPoints = "{0} stats points left";
        public const string AddStatPoint = ":heavy_plus_sign:";
        public const string AttackStat = ":dagger_knife: Attack : {0}";
        public const string DefenseStat = ":shield: Defense : {0}";
        public const string DodgeStat = ":dizzy: Dodge : {0}";
        public const string HitrateStat = ":anger: Hit Rate : {0}";
        public const string GambleStat = ":money_with_wings: Gamble Chance : {0:0.##}%";
        public const string WonGamble = "{0} flipped a coin and won {1} " + CreditEmoji;
        public const string LostGamble = "{0} flipped a coin and lost {1} " + CreditEmoji;
        public const string ChallengeSent = "{0} challenged {1} to a coinflip for {2} " + CreditEmoji;
        public const string GambleChallenge = "{0} won {1} " + CreditEmoji + " in a coin flip against {2}";
        public const string GambleDeclined = "{0} declined {1}'s request, what a loser.";
        public const string InsufficientCredits = "{0} need to have at least {1} " + CreditEmoji;
        public const string GambleChallengeTip = "You were challenged to a coin flip, type in `/gamblechallenge accept` to accept or `/gamblechallenge decline` to decline";
        public const string UserFlamedYou = "{0} flamed you.";
        public const string YouIdiot = "You idiot.";
        public const string StealCredits = "You stole {0} " + CreditEmoji + " from {1}.";
        public const string StealCreditsCaught = "{0} stole {1} " + CreditEmoji + " from {2}!";
        public const string StealFail = "You attempted to steal from {0}, but failed.";
        public const string StealFailCaught = "{0} attempted to steal from {1} but failed!";
        public const string RecoverItem = "You used *{0}* and recovered {1} {2}.";
        public const string UserGaveItem = "{0} gave *{1}* to {2}.";
        public const string ConsumedItem = "You consumed the item.";
        public const string LevelUp = ":confetti_ball: {0} is now level *{1}*!";
        public const string GainedExp = "You gained {0} experience points.";
        public const string EquippedItem = "You equipped *{0}*.";
        public const string BuyFor = "Buy for {0} " + CreditEmoji;
        public const string UserDied = "Oh dear, {0} died!";
        public const string Use = "Use";
        public const string Equip = "Equip";
        public const string UnEquip = "Unequip";
        public const string Sell = "Sell for {0} " + CreditEmoji;
        public const string Quantity = "*Quantity:* {0} ";
        public const string SoldItem = "You sold *{0}* for {1} " + CreditEmoji;
        public const string Inventory = "Inventory";
        public const string Equipment = "Equipment";
        public const string GeneralStore = "General Store";
        public const string ArmoryShop = "Armory";
        public const string MagicShop = "Diagon Alley";
        public const string RogueShop = "Rogue Emporium";
        public const string PeasantShop = "Peasant Supplies";
        public const string Info = "Info";
        public const string UnequippedItem = "You unequipped *{0}*.";
        public const string Target = "Target ...";
        public const string Give = "Give ...";
        public const string SelectTarget = "Select a target";
        public const string SelectTargetText = "Please select a user to target with this action.";
        public const string UserAttackedTarget = "{0} dealt {2} damage to {1}!";
        public const string UsedItemOnTarget = "{0} used a *{1}* on {2}";
        public const string AddedEffect = "You obtained the *{0}* effect for {1} minutes";
        public const string Surrendered = "{0} has surrendered :fr:";
        public const string Missed = "{0} missed their attack on {1}!";
        public const string CriticalHit = "{0} dealt *{2}* critical damage to {1}!";
        public const string RevolutionVote = "{0} wants to lead the revolution :fire: who's with em?";
        public const string RevolutionSucceeded = "<!here> - Off with {0}'s head! {1} is the new emperor!";
        public const string Cleansed = "You are cleansed of all your effects.";
        public const string LootboxAnnouncement = "{0} opened *{1}* and received {2}";
        public const string ItemLevel = "*Level {0}*";
        public const string ItemAttack = "`Attack {0}-{1}`";
        public const string ItemDefense = "`Defense {0:+#;-#}`";
        public const string ItemResistance = "`Resistance {0:+#;-#}`";
        public const string ItemHitrate = "`Hitrate {0:+#;-#}`";
        public const string ItemDodge = "`Dodge {0:+#;-#}`";
        public const string ItemHealth = "`Health {0:+#;-#}`";
        public const string ItemEnergy = "`Energy {0:+#;-#}`";
        public const string ItemStrength = "`Strength {0:+#;-#}`";
        public const string ItemAgility = "`Agility {0:+#;-#}`";
        public const string ItemIntelligence = "`Intelligence {0:+#;-#}`";
        public const string ItemConstitution = "`Constitution {0:+#;-#}`";
        public const string ItemLuck = "`Luck {0:+#;-#}`";
        public const string AttackSpeed = "`Speed: {0:0.##}`";
        public const string ItemDualWield = "*Two Handed*";
        public const string ItemLeftHand = "*Left Handed*";
        public const string ItemRightHand = "*Right Handed*";
        public const string SmallHealthDisplay = "{0} HP";
        public const string UserIsInvincible = "{0} is invincible!";
        public const string MonsterSpawned = "*{0}* has spawned!";
        public const string AttackAction = "Attack";
        public const string SkillAction = "Skill";
        public const string MonsterDied = "*{0}* Died!";
        public const string UserObtained = "{0} obtained {1}";
        public const string YouObtained = "You obtained {0}";
        public const string Agi = "Agi";
        public const string Str = "Str";
        public const string Con = "Con";
        public const string Luck = "Luck";
        public const string Int = "Int";
        public const string UserHealed = "{0} healed {1} for *{2}* health";
        public const string UserActivatedSkill = "{0} cast {1}";

        public const string DougError = "Beep boop, it's not working : {0}";
        public const string NotAnAdmin = "You are not an admin.";
        public const string InvalidArgumentCount = "You provided an invalid argument count.";
        public const string InvalidAmount = "Invalid amount";
        public const string NotEnoughCredits = "You need {0} " + CreditEmoji + " to do this and you have {1} " + CreditEmoji;
        public const string SlursAreClean = "There is nothing to cleanup.";
        public const string AlreadyChallenged = "This user is already challenged.";
        public const string NotChallenged = "You are not challenged.";
        public const string SlurAlreadyExists = "That slur already exists.";
        public const string NotEnoughEnergy = "You don't have enough energy.";
        public const string NoItemInSlot = "There is no item in slot {0}.";
        public const string ItemCantBeUsed = "This item cannot be used";
        public const string InvalidUserArgument = "You must pass a valid user in arguments";
        public const string ItemNotEquipAble = "This item is not equipable.";
        public const string NoMoreStatsPoints = "No more available stats points.";
        public const string NoEquipmentInSlot = "No equipment in slot {0}";
        public const string NotInRightChannel = "You cannot perform this action in this channel.";
        public const string UserIsNotInPvp = "The target user is not in the pvp channel.";
        public const string ItemNotTradable = "This item is not tradable.";
        public const string EmptyInventory = "Oops, yer loot seems empty, buy more at th' shop now.";
        public const string LevelRequirementNotMet = "You do not meet the level requirements to equip this item.";
        public const string CommandOnCooldown = "This action is on cooldown, try again in {0} seconds.";
        public const string UnknownShop = "Unknown shop. Verify the shop id.";
        public const string UserMustBeActive = "The user you are targetting must be active.";
        public const string YouMustBeActive = "You must be active for this.";
        public const string RevolutionCooldown = "You must wait {0} minutes until the next revolution";
        public const string SkillCannotBeActivated = "This skill cannot be activated.";
        public const string SkillNeedsTarget = "You must specify a target.";
    }
}

