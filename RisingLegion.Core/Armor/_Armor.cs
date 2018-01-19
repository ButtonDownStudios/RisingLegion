using System.Collections.Generic;
using RisingLegion.Helpers.Enum.People;

namespace RisingLegion.Core.Armor
{
    public abstract class _Armor : IArmor
    {
        public List<StatTypes> StatTypeses { get; set; }
    }
}