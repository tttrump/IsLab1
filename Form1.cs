using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace lab_1
{
    public partial class Form1 : Form
    {
        Color Any = new Color(1, "Любой");
        Color White = new Color(2, "Белый");
        Color Black = new Color(3, "Черный");
        Color Red = new Color(4, "Красный");
        Color Blue = new Color(5, "Синий");
        Color Green = new Color(6, "Зеленый");
        Color Grey = new Color(7, "Серый");
        Color Yellow = new Color(8, "Желтый");
        Color Orange = new Color(9, "Оранжевый");
        List<Car> DB = new List<Car>();
        public Form1()
        {
            InitializeComponent();

            List<Color> colors = new List<Color>
            {White, Black, Red, Blue, Green, Grey,Yellow, Orange, Any};

            comboBox1.DataSource = colors;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";


            DB.Add(new Car("Porsche 911", 8200000, 2019, "AT", "AWD", Green, "Class_S"));
            DB.Add(new Car("Nissan GT-R", 7700000, 2020, "AT", "AWD", Orange, "Class_S"));
            DB.Add(new Car("Ferrari 488", 26800000, 2018, "AT", "RWD", Red, "Class_S"));

            DB.Add(new Car("Alfa Romeo 4C", 4100000, 2016, "AT", "RWD", Red, "Class_H"));
            DB.Add(new Car("Bentley Continental GTC", 15000000, 2016, "AT", "AWD", White, "Class_H"));
            DB.Add(new Car("Mercedes AMG GT", 9000000, 2018, "AT", "RWD", Yellow, "Class_H"));

            DB.Add(new Car("MINI Coupe", 1000000, 2011, "AT", "FWD", Blue, "Class_G"));
            DB.Add(new Car("Mercedes-Benz C-coupe", 1200000, 2014, "AT", "RWD", White, "Class_G"));
            DB.Add(new Car("Ford Mustang VI", 2000000, 2019, "AT", "RWD", Black, "Class_G"));

            DB.Add(new Car("Volkswagen up", 400000, 2013, "AT", "FWD", Red, "Class_A"));
            DB.Add(new Car("Fiat 500", 1000000, 2017, "AT", "FWD", White, "Class_A"));
            DB.Add(new Car("Kia Picanto", 550000, 2014, "MT", "FWD", Yellow, "Class_A"));

            DB.Add(new Car("Hyundai Solaris II", 850000, 2017, "AT", "FWD", Blue, "Class_B"));
            DB.Add(new Car("Lada Веста", 640000, 2018, "MT", "FWD", Grey, "Class_B"));
            DB.Add(new Car("Volkswagen Polo", 625000, 2016, "AT", "FWD", White, "Class_B"));

            DB.Add(new Car("Kia Ceed", 1300000, 2018, "AT", "FWD", Grey, "Class_C"));
            DB.Add(new Car("Ford Focus", 710000, 2015, "MT", "FWD", Black, "Class_C"));
            DB.Add(new Car("Mazda 3", 640000, 2012, "MT", "FWD", Red, "Class_C"));

            DB.Add(new Car("Ford Mondeo", 925000, 2015, "MT", "FWD", White, "Class_D"));
            DB.Add(new Car("Honda Accord", 2350000, 2018, "AT", "FWD", Grey, "Class_D"));
            DB.Add(new Car("Toyota Camry", 2695000, 2020, "AT", "FWD", Black, "Class_D"));

            DB.Add(new Car("Jaguar XF", 1250000, 2013, "AT", "RWD", Black, "Class_E"));
            DB.Add(new Car("Mercedes-Benz E-class", 3990000, 2019, "AT", "AWD", Grey, "Class_E"));
            DB.Add(new Car("Lexus ES", 2199000, 2018, "AT", "FWD", White, "Class_E"));

            DB.Add(new Car("Rolls-Royce Phantom", 10800000, 2006, "AT", "RWD", White, "Class_F"));
            DB.Add(new Car("Maybach 62", 6499999, 2008, "AT", "RWD", Black, "Class_F"));
            DB.Add(new Car("Hyundai Equus", 1351000, 2013, "AT", "RWD", Grey, "Class_F"));

            DB.Add(new Car("Toyota Land Cruiser 200 Series", 5350000, 2018, "AT", "AWD", Black, "Class_J"));
            DB.Add(new Car("Honda CR–V", 1900000, 2017, "AT", "AWD", Grey, "Class_J"));
            DB.Add(new Car("Toyota RAV4", 2214816, 2018, "AT", "AWD", White, "Class_J"));

            DB.Add(new Car("Citroen SpaceTourer", 2119300, 2020, "AT", "FWD", Black, "Class_M"));
            DB.Add(new Car("Ford C-max", 305000, 2006, "MT", "FWD", Grey, "Class_M"));
            DB.Add(new Car("Kia Carens", 509000, 2009, "AT", "FWD", White, "Class_M"));
        }

        Dictionary<string, double> autos = new Dictionary<string, double>();


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color color = (Color)comboBox1.SelectedItem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            autos.Clear();
            autos.Add("Class_A", 0);
            autos.Add("Class_B", 0);
            autos.Add("Class_C", 0);
            autos.Add("Class_D", 0);
            autos.Add("Class_E", 0);
            autos.Add("Class_F", 0);
            autos.Add("Class_J", 0);
            autos.Add("Class_M", 0);
            autos.Add("Class_S", 0);
            autos.Add("Class_H", 0);
            autos.Add("Class_G", 0);

            string transmission = "", drive = "";
            long price;
            int year;
            if (radioAT.Checked) transmission = "AT";
            if (radioMT.Checked) transmission = "MT";
            if (radioFull.Checked) drive = "AWD";
            if (radioBack.Checked) drive = "RWD";
            if (radioFront.Checked) drive = "FWD";
            price = Convert.ToInt64(PriceTB.Text);
            year = Convert.ToInt32(YearTB.Text);
            Color color = (Color)comboBox1.SelectedItem;
            int checkedNumber = 0;
            if (checkBox1.Checked == true) checkedNumber++;
            if (checkBox2.Checked == true) checkedNumber++;
            if (checkBox3.Checked == true) checkedNumber++;
            if (checkBox4.Checked == true) checkedNumber++;
            if (checkBox5.Checked == true) checkedNumber++;
            if (checkBox6.Checked == true) checkedNumber++;
            if (checkBox7.Checked == true) checkedNumber++;
            if (checkBox8.Checked == true) checkedNumber++;
            if (checkBox9.Checked == true) checkedNumber++;
            if (checkBox10.Checked == true) checkedNumber++;

            if (checkBox1.Checked == true)
            {
                autos["Class_A"] += 1 / checkedNumber;
                autos["Class_B"] += 1 / checkedNumber;
                autos["Class_C"] += 1 / checkedNumber;
            }

            if (checkBox2.Checked == true)
            {
                autos["Class_C"] += 1 / checkedNumber;
                autos["Class_D"] += 1 / checkedNumber;
                autos["Class_J"] += 1 / checkedNumber;
                autos["Class_M"] += 1 / checkedNumber;
            }

            if (checkBox3.Checked == true)
            {
                autos["Class_J"] += 1 / checkedNumber;
            }

            if (checkBox4.Checked == true)
            {
                autos["Class_E"] += 1 / checkedNumber;
                autos["Class_F"] += 1 / checkedNumber;
                autos["Class_J"] += 1 / checkedNumber;
                autos["Class_S"] += 1 / checkedNumber;
                autos["Class_H"] += 1 / checkedNumber;
            }

            if (checkBox5.Checked == true)
            {
                autos["Class_E"] += 1 / checkedNumber;
                autos["Class_S"] += 1 / checkedNumber;
                autos["Class_H"] += 1 / checkedNumber;
                autos["Class_G"] += 1 / checkedNumber;
            }

            if (checkBox6.Checked == true)
            {
                autos["Class_A"] += 1 / checkedNumber;
            }

            if (checkBox7.Checked == true)
            {
                autos["Class_E"] += 1 / checkedNumber;
                autos["Class_F"] += 1 / checkedNumber;
                autos["Class_J"] += 1 / checkedNumber;
                autos["Class_M"] += 1 / checkedNumber;
                autos["Class_G"] += 1 / checkedNumber;
            }

            if (checkBox8.Checked == true)
            {
                autos["Class_A"] += 1 / checkedNumber;
                autos["Class_B"] += 1 / checkedNumber;
                autos["Class_C"] += 1 / checkedNumber;
                autos["Class_D"] += 1 / checkedNumber;
            }

            if (checkBox9.Checked == true)
            {
                autos["Class_D"] += 1 / checkedNumber;
                autos["Class_J"] += 1 / checkedNumber;
            }

            if (checkBox10.Checked == true)
            {
                autos["Class_E"] += 1 / checkedNumber;
                autos["Class_F"] += 1 / checkedNumber;
                autos["Class_J"] += 1 / checkedNumber;
                autos["Class_S"] += 1 / checkedNumber;
                autos["Class_G"] += 1 / checkedNumber;
            }

            double max = autos.Values.Max();
            List<string> validClass = new List<string>();
            foreach (var x in autos)
                if (x.Value == max) validClass.Add(x.Key);

            List<Car> ansList = DB.Where(x => (validClass.IndexOf(x.carClass) > -1)
            && (x.price <= price) && (x.yearOfRelease >= year) && (x.transmition.Equals(transmission))
            && (x.drive.Equals(drive)) && (color == Any || x.color == color)).ToList();

            string answer = "";
            AnsTB.Text = "";
            foreach (var x in ansList)
                answer += x.nameCar + "\r\n";
            if (ansList.Count == 0)
                answer = "К сожалению, мы не смогли найти машину, удовлетворяющую Вашим запросам";
            AnsTB.Text = answer;
        }
    }


    class Color
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Color(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    class Car
    {
        public string nameCar;
        public long price;
        public int yearOfRelease;
        public string transmition; // КПП
        public string drive; // привод
        public Color color;
        public string carClass;

        public Car(string name, long price, int year, string transmition, string drive, Color color, string carClass)
        {
            nameCar = name;
            this.price = price;
            yearOfRelease = year;
            this.transmition = transmition;
            this.drive = drive;
            this.color = color;
            this.carClass = carClass;
        }
    }
}