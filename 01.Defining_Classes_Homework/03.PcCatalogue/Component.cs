namespace _02.PcCatalogue
{
    using System;

    class Component
    {
        private string name = null;
        private string details = null;
        private double price = 0.0d;

        public Component(string name)
            : this(name, 0)
        { }

        public Component(string name, double price)
            : this(name, price, "No details provided")
        { }

        public Component(string name, double price, string details)
        {
            this.Name = name;
            this.Price = price;
            this.Details = details;
        }

        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Insert Positive price");
                }
                this.price = value;
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                this.details = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Not allowed empty string for name");
                }
                this.name = value;
            }
        }
    }
}
