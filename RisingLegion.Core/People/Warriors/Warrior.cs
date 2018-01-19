using System;

namespace RisingLegion.Core.People.Warriors
{
    public class Warrior
    {
        public Warrior()
        {
            Random rnd = new Random();
            WarriorIncreaseByLevel = rnd.Next(1, 100);
        }
        public Warrior(double warriorIncreaseByLevel, int talent, int currentRank)
        {
            WarriorIncreaseByLevel = warriorIncreaseByLevel;
            Talent = talent;
            CurrentRank = currentRank;
        }
        public int CurrentRank { get; set; }
        private double WarriorIncreaseByLevel { get; }
        private int Talent { get; }

        public long MaxHealth
        {
            get
            {
                var totalIncrease = WarriorIncreaseByLevel + Talent;
                totalIncrease = totalIncrease / 1.5;
                double total = 1;
                for (var i = 0; i < CurrentRank; i++)
                {
                    total = total * totalIncrease;
                }
                return (long) total;
            }
        }
        
        public long MaxDamage
        {
            get
            {
                double totalIncrease = WarriorIncreaseByLevel + Talent;
                totalIncrease = totalIncrease / 3;
                double total = 1;
                for (int i = 0; i < CurrentRank; i++)
                {
                    total = total * totalIncrease;
                }
                return (long) total;
            }
        }
    }
}