namespace RisingLegion.Core.Weapon
{
    public class Bow : _Weapon
    {
        public Bow()
        {
            IsMelee = false;
            IsMagic = false;
            IsRanged = true;
        }
    }
}