using System.Collections.Generic;

namespace lab_1
{
    class DisplayType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DisplayType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static readonly DisplayType Any = new DisplayType(1, "Любой");
        public static readonly DisplayType oled = new DisplayType(2, "OLED");
        public static readonly DisplayType amoled = new DisplayType(3, "AMOLED");
        public static readonly DisplayType samoled = new DisplayType(4, "SUPER AMOLED");
        public static readonly DisplayType damoled = new DisplayType(5, "Dynamic AMOLED");
        public static readonly DisplayType ips = new DisplayType(6, "IPS");
        public static readonly DisplayType retina = new DisplayType(7, "Super Retina XDR");
        public static readonly List<DisplayType> displayTypes = new List<DisplayType>
            {Any, oled, amoled, samoled, damoled, ips, retina};

    }
}
