using RisingLegion.Core.Magic;
using RisingLegion.Helpers.Enum.Weapon;

namespace RisingLegion.Core.Weapon
{
    public class _Weapon : IWeapon
    {
        public Rarity Rarity { get; set; }
        public Element Element { get; set; }
        public bool IsMelee { get; set; }
    }
}