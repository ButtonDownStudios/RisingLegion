namespace RisingLegion.Core.Weapon
{
    public class Sword : _Weapon
    {
        public Sword()
        {
            IsMelee = true;
            IsMagic = false;
            IsRanged = false;
        }
    }
}