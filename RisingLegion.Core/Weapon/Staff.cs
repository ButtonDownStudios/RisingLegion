namespace RisingLegion.Core.Weapon
{
    public class Staff : _Weapon
    {
        public Staff()
        {
            IsMelee = false;
            IsMagic = true;
            IsRanged = false;
        }
    }
}