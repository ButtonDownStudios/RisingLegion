using System.Collections.Generic;
using System.Linq;
using RisingLegion.Core.Magic;
using RisingLegion.Core.People.Warriors;
using RisingLegion.Core.Stats;
using RisingLegion.Core.Weapon;
using RisingLegion.Helpers.Enum.People;
using RisingLegion.Helpers;

namespace RisingLegion.Core.People
{
    public class Human : _People
    {
        #region Constructor

        public Human(long age, int talent)
        {
            Age = age;
            var currentRank = GetCurrentRank(Constants.baseExperienceNeeded, talent, Constants.MaxWarriorLevel);
            Warrior = new Warrior(Constants.DefaultWarriorIncrease, talent, currentRank);
        }

        #endregion

        #region Personal Info

        public string Name { get; set; }
        public string FamilyName { get; set; }

        #endregion

        #region Attributes

        public long MaxHealth { get; set; }
        public long CurrentHealth { get; set; }
        public long MaxDamage { get; set; }
        public long MaxDefense { get; set; }
        public List<Element> Elements { get; set; }
        public List<IStat> Attributeses { get; set; }

        public long CurrentIntelligence => GetCurrentAttribute(StatTypes.Intelligence);
        public long CurrentStrength => GetCurrentAttribute(StatTypes.Strength);
        public long CurrentDexterity => GetCurrentAttribute(StatTypes.Dexterity);

        #endregion

        #region Inventory

        public List<IWeapon> Weapons { get; set; }

        #endregion

        #region Rank

        public Warrior Warrior { get; }

        #endregion

        #region PrivateMethods
        
        private long GetCurrentAttribute(StatTypes statType)
        {
            return Attributeses.Where(attributese => attributese.GetAttribute() == statType).Aggregate<IStat, long>(0, (current, attributese) => current + attributese.GetAmount());
        }

        private int GetCurrentRank(int baseExperience, int talent, int maxLevel)
        {
            var currentLevel = 1;
            var experienceNeeded = baseExperience;
            var totalExperience = 0;
            int experienceMultiplier = 1;
            for (var i = 0; i < Age; i++)
            {
                totalExperience = totalExperience + talent;
                if (totalExperience <= experienceNeeded) continue;
                currentLevel++;
                experienceNeeded = experienceNeeded + experienceNeeded * experienceMultiplier;
                experienceMultiplier++;
                if (currentLevel >= maxLevel)
                    break;
            }
            return currentLevel;
        }

        #endregion
        
    }
}