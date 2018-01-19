using RisingLegion.Helpers.Enum.Magic;

namespace RisingLegion.Core.Magic
{
    public class Element : _Magic
    {
        public Elements ElementType { get; set; }
        public int ElementAfinity { get; set; }
    }
}