using RisingLegion.Helpers.Enum.People;

namespace RisingLegion.Core.Stats
{
    public interface IStat
    {
        long GetAmount();
        StatTypes GetAttribute();
    }
}