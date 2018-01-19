using RisingLegion.Helpers.Enum.People;

namespace RisingLegion.Core.Stats
{
    public abstract class _Stats : IStat
    {
        protected StatTypes StatType { get; set; }
        public long Amount { get; set; }    
        
        public long GetAmount()
        {
            return Amount;
        }

        public StatTypes GetAttribute()
        {
            return StatType;
        }
    }    
}