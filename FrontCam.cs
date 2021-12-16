using System.Collections.Generic;

namespace lab_1
{
    class FrontCam
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public FrontCam(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static readonly FrontCam Any = new FrontCam(1, "Любая");
        public static readonly FrontCam above = new FrontCam(2, "Над дисплеем");
        public static readonly FrontCam drop = new FrontCam(3, "Каплевидная");
        public static readonly FrontCam island = new FrontCam(4, "Островная");
        public static readonly FrontCam hidden = new FrontCam(5, "Скрытая");
        public static readonly FrontCam eyebrow = new FrontCam(6, "Шторкой");
        public static readonly FrontCam absent = new FrontCam(7, "Отсутствует");
        public static readonly List<FrontCam> frontCams = new List<FrontCam>
            {Any, above, drop, island, hidden, eyebrow, absent};

    }
}