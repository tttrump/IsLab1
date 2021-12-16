using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace lab_1
{
    public partial class mainForm : Form
    {
        List<Cellphone> DB = new List<Cellphone>();

        long price;
        int diag;
        Color color;
        DisplayType displayType;
        FrontCam frontCam;
        List<int> criteria = new List<int>();
        public mainForm()
        {
            InitializeComponent();
            colorCB.DataSource = Color.colors;
            colorCB.DisplayMember = "Name";
            colorCB.ValueMember = "Id";

            displayTypeCB.DataSource = DisplayType.displayTypes;
            displayTypeCB.DisplayMember = "Name";
            displayTypeCB.ValueMember = "Id";

            frontCamCB.DataSource = FrontCam.frontCams;
            frontCamCB.DisplayMember = "Name";
            frontCamCB.ValueMember = "Id";

            DBLoader loader = new DBLoader();
            loader.load();
            DB = loader.GetDB();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            getDataFromForm();
            PhoneClassResolver res = new PhoneClassResolver(criteria);

            List<Cellphone> ansList = DB.Where(x => (res.valideClasses().IndexOf(x.phoneClass) > -1)
            && (x.price <= price) && (x.diag >= diag) && (displayType == DisplayType.Any || x.displayType == displayType)
            && (frontCam == FrontCam.Any || x.frontCam == frontCam) && (color == Color.Any || x.color == color)).ToList();

            ansList.Sort(
                delegate (Cellphone x, Cellphone y)
                {
                    return x.price.CompareTo(y.price);
                });

            string answer = ""; AnsTB.Text = "";
            foreach (var x in ansList)
                answer += x.color.Name + " " + x.phoneName + "\r\n" +
                    x.diag + "' " + x.frontCam.Name + " " + x.displayType.Name + "\r\n" +
                    x.price + " рублей \r\n\r\n";

            if (ansList.Count == 0)
                answer = "Нам не удалось подобрать телефон, удовлетворяющий Вашим запросам";
            AnsTB.Text = answer;
        }

        private void getDataFromForm()
        {
            price = Convert.ToInt64(PriceTB.Text);
            diag = Convert.ToInt32(diagTB.Text);
            color = (Color)colorCB.SelectedItem;
            displayType = (DisplayType)displayTypeCB.SelectedItem;
            frontCam = (FrontCam)frontCamCB.SelectedItem;
            criteria.Clear();
            foreach (CheckBox x in criteriaPanel.Controls)
                if (x.Checked)
                    criteria.Add(Convert.ToInt32(x.Tag));
        }
    }
}