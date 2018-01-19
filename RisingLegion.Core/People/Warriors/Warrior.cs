namespace RisingLegion.Core.People.Warriors
{
    public class Warrior
    {
        public Warrior(double warriorIncreaseByLevel, int talent, int currentRank)
        {
            WarriorIncreaseByLevel = warriorIncreaseByLevel;
            Talent = talent;
            CurrentRank = currentRank;
        }
        
        private int CurrentRank { get; }
        private double WarriorIncreaseByLevel { get; }
        private int Talent { get; }

        public long BaseHealth => getTotalByTalent(1.5);

        public long BaseDamage => getTotalByTalent(3);

        public long BaseDefense => getTotalByTalent(4);

        private long getTotalByTalent(double increaseDivider)
        {
            var totalIncrease = WarriorIncreaseByLevel + Talent;
            totalIncrease = totalIncrease / increaseDivider;
            double total = 1;
            for (int i = 0; i < CurrentRank; i++)
            {
                total = total * totalIncrease;
            }
            return (long) total;
        }
    }
}