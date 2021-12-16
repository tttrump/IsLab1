using System.Collections.Generic;

namespace lab_1
{
    class Color
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Color(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static readonly Color Any = new Color(1, "Любой");
        public static readonly Color White = new Color(2, "Белый");
        public static readonly Color Black = new Color(3, "Черный");
        public static readonly Color Silver = new Color(4, "Серебристый");
        public static readonly Color Green = new Color(5, "Зеленый");
        public static readonly List<Color> colors = new List<Color>
            {Any, White, Black, Silver, Green};

    }
}
