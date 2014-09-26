namespace LaptopShop
{
    class Battery
    {
        private string type;
        private uint batteryLife;


        public Battery(string type)
            : this(type, 3)
        {

        }

        public Battery(string type, uint batteryLife)
        {
            this.Type = type;
            this.BatteryLife = batteryLife;
        }


        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public uint BatteryLife
        {
            get
            {

                return this.batteryLife;
            }
            set
            {
                // //if batteryLife is int
                //if (value < 0)
                //{
                //    throw new IndexOutOfRangeException("positive number is expected");

                //}
                this.batteryLife = value;
            }
        }
    }
}
