using System;
using System.Collections.Generic;
using System.IO;
//загружаем базу данных
namespace lab_1
{
    class DBLoader
    {
        private readonly static string DATABASE_FILENAME = "DataBase.txt";
        StreamReader reader = File.OpenText(DATABASE_FILENAME);
        List<Cellphone> DB = new List<Cellphone>();
        public void load()
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] items = line.Split('\t');
                String name = items[0];
                name = name.Replace("\"", "");
                long price = Convert.ToInt64(items[1]);
                int diag = Convert.ToInt32(items[2]);
                string raw_color = items[3];
                string raw_displayType = items[4];
                string raw_frontCam = items[5];
                string phone_class = items[6];
                Color color = Color.Any;
                DisplayType displayType = DisplayType.Any;
                FrontCam frontCam = FrontCam.Any;
                switch (raw_color)
                {
                    case "Черный":
                        color = Color.Black;
                        break;
                    case "Белый":
                        color = Color.White;
                        break;
                    case "Серебристый":
                        color = Color.Silver;
                        break;
                    case "Зеленый":
                        color = Color.Green;
                        break;
                }
                switch (raw_displayType)
                {
                    case "OLED":
                        displayType = DisplayType.oled;
                        break;
                    case "AMOLED":
                        displayType = DisplayType.amoled;
                        break;
                    case "SUPER AMOLED":
                        displayType = DisplayType.samoled;
                        break;
                    case "Dynamic AMOLED":
                        displayType = DisplayType.damoled;
                        break;
                    case "IPS":
                        displayType = DisplayType.ips;
                        break;
                    case "Super Retina XDR":
                        displayType = DisplayType.retina;
                        break;
                }
                switch (raw_frontCam)
                {
                    case "Над дисплеем":
                        frontCam = FrontCam.above;
                        break;
                    case "Каплевидная":
                        frontCam = FrontCam.drop;
                        break;
                    case "Островная":
                        frontCam = FrontCam.island;
                        break;
                    case "Скрытая":
                        frontCam = FrontCam.hidden;
                        break;
                    case "Шторкой":
                        frontCam = FrontCam.eyebrow;
                        break;
                    case "Отсутствует":
                        frontCam = FrontCam.absent;
                        break;
                }
                DB.Add(new Cellphone(name, price, diag, displayType, frontCam, color, phone_class));
            }
        }
        public List<Cellphone> GetDB()
        {
            return DB;
        }
    }
}
