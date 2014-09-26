namespace LaptopShop
{
    using System;
    using System.Text;

    class Laptop
    {
        private string model = null;
        private string manufacturer = null;
        private string processor = null;
        private string graphicsCard = null;
        private Battery battery = new Battery(null);
        private Screen screen = new Screen(null);
        private uint price = 0;


        public Laptop(string model, uint price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(string model, string manufacturer)
            : this(model, manufacturer, "Intel i7", "Nvidia GeForce GTX", new Battery("NiMH"), new Screen("LED"), 1200)
        { }


        public Laptop(string model, string manufacturer, string processor,
            string graphicsCard, Battery battery, Screen screen, uint price)
        {
            Model = model;
            Manufacturer = manufacturer;
            Processor = processor;
            GraphicsCard = graphicsCard;
            this.battery = battery;
            this.screen = screen;
            Price = price;

        }


        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                CheckForEmptyString(value);
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                CheckForEmptyString(value);
                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                CheckForEmptyString(value);
                this.processor = value;
            }
        }

        public string GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }
            set
            {
                CheckForEmptyString(value);
                this.graphicsCard = value;
            }
        }

        public uint Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }


        private static void CheckForEmptyString(string value)
        {
            if (value == "")
            {
                throw new ArgumentException("String values cannot be empty");
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            if (Manufacturer == null)
            {
                result.AppendFormat("Laptop:\nmodel: {0}\nprice: {1}", Model, Price);
            }
            else
            {
                result.AppendFormat("Laptop:\nmodel: {0}\nmanufacturer: {1}\n"
          + "processor: {2}\ngraphics Card: {3}", Model, Manufacturer, Processor, GraphicsCard);
                result.AppendLine("\n.........");
                result.AppendFormat("Battery:\ntype: {0}\nlife: {1} hours", this.battery.Type, this.battery.BatteryLife);
                result.AppendLine("\n.........");
                result.AppendFormat("Screen:\ntype:{0}\nresolution: {1}x{2}", this.screen.Type, this.screen.Width, this.screen.Height);
                result.AppendLine("\n.........");
                result.AppendFormat("Price: {0} lv.", this.price);
                result.AppendLine("\n########################################");

            }

            return result.ToString();
        }
    }
}
