namespace _02.PcCatalogue
{
    using System;
    using System.Collections.Generic;

    class Computer : Component, IComponentable
    {

        List<Component> components = new List<Component>();
        private double totalPrice;

        public Computer(string name)
            : base(name)
        {

        }

        public Computer(string name, List<Component> components)
            : base(name)
        {
            this.Name = name;
            this.Components = components;
        }

        public double TotalPrice
        {
            get
            {
                return this.totalPrice;
            }
            private set
            {
                this.totalPrice = value;
            }
        }

        public List<Component> Components
        {
            get
            {
                return this.components;
            }
            set
            {
                this.components = value;
            }
        }

        public void AddComponent(Component component)
        {
            this.Components.Add(component);
        }

        public void SumTotalPrice(List<Component> items)
        {
            double totalSum = 0d;
            foreach (var item in items)
            {
                totalSum += item.Price;
            }

            this.TotalPrice = totalSum;
        }

        public void DisplayPcInfo()
        {
            Console.WriteLine("PC name: {0}\nComponents:", this.Name);

            foreach (var item in Components)
            {
                Console.WriteLine("Name: {0} / Details: {2} / Price: {1} лв. ", item.Name, item.Price, item.Details);
            }

            Console.WriteLine("Total PC price: {0} лв", this.TotalPrice);
        }
    }
}
