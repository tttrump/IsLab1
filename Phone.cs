namespace lab_1
{
    class Cellphone
    {
        public string phoneName; 
        public long price;
        public int diag;
        public DisplayType displayType; // тип дисплея
        public FrontCam frontCam; // тип фронталки
        public Color color;
        public string phoneClass;

        public Cellphone(string phoneName, long price, int diag, DisplayType displayType, FrontCam frontCam, Color color, string phoneClass)
        {
            this.phoneName = phoneName;
            this.price = price;
            this.diag = diag;
            this.displayType = displayType;
            this.frontCam = frontCam;
            this.color = color;
            this.phoneClass = phoneClass;
        }
    }
}
