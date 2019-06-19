﻿using Doug.Models.Dto;
using System.Collections.Generic;

namespace Doug.Models
{
    public class Attachment
    {
        public string Fallback { get; set; }
        public string Color { get; set; }
        public string Pretext { get; set; }
        public List<Field> Fields { get; set; }

        public Attachment()
        {
            Fields = new List<Field>();
        }

        public static Attachment DeletedSlursAttachment(List<Slur> slurs)
        {
            var attachment = new Attachment()
            {
                Fallback = DougMessages.SlursCleaned,
                Color = "#e05f28",
                Pretext = DougMessages.SlursCleaned
            };

            slurs.ForEach(slur => attachment.Fields.Add(new Field(slur.Text)));

            return attachment;
        }

        public static Attachment StatsAttachment(int slurCount, User user)
        {
            var title = string.Format(DougMessages.StatsOf, Utils.UserMention(user.Id));

            var attachment = new Attachment()
            {
                Fallback = title,
                Color = "#69FF69",
                Pretext = title
            };

            attachment.Fields.Add(new Field(string.Format(DougMessages.UserIdStats, user.Id)));
            attachment.Fields.Add(new Field(string.Format(DougMessages.CreditStats, user.Credits)));
            attachment.Fields.Add(new Field(string.Format(DougMessages.SlursAddedStats, slurCount)));
            attachment.Fields.Add(new Field(string.Format(DougMessages.HealthStats, user.Health, user.CalculateTotalHealth())));
            attachment.Fields.Add(new Field(string.Format(DougMessages.EnergyStats, user.Energy, user.CalculateTotalEnergy())));
            attachment.Fields.Add(new Field(string.Format(DougMessages.DefenceStats, user.Defence)));
            attachment.Fields.Add(new Field(string.Format(DougMessages.CharismaStats, user.Charisma)));
            attachment.Fields.Add(new Field(string.Format(DougMessages.AgilityStats, user.Agility)));
            attachment.Fields.Add(new Field(string.Format(DougMessages.LuckStats, user.Luck)));

            attachment.Fields.Add(new Field(DougMessages.ItemStats));
            user.InventoryItems.ForEach(inventoryItem => attachment.Fields.Add(new Field(string.Format("{0} - {2} {1}", inventoryItem.InventoryPosition, inventoryItem.Item.Name, inventoryItem.Item.Icon))));

            return attachment;
        }

        public static Attachment LeaderboardAttachment(List<UsersStatsDto> users)
        {
            var title = string.Format(DougMessages.Top5);

            var attachment = new Attachment()
            {
                Fallback = title,
                Color = "#69FF69",
                Pretext = title
            };

            foreach (var user in users)
            {
                attachment.Fields.Add(new Field(string.Format("{0} : {1}", user.Username, user.Credits)));
            }

            return attachment;
        }
    }

    public class Field
    {
        public string Title { get; set; }
        public bool Short { get; set; }

        public Field(string text)
        {
            Title = text;
            Short = false;
        }
    }
}
