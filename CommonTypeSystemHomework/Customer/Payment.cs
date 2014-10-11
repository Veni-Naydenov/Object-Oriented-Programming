namespace Customer
{
    using System.Text;

    public class Payment
    {
        private string productName = null;
        private decimal productPrice = 0;

        public Payment(string name, decimal price)
        {
            this.ProductName = name;
            this.productPrice = price;
        }

        public decimal ProductPrice
        {
            get
            {
                return this.productPrice;
            }
            set
            {
                this.productPrice = value;
            }
        }

        public string ProductName
        {
            get
            {
                return this.productName;
            }
            set
            {
                this.productName = value;
            }
        }

        public override string ToString()
        {
            StringBuilder paymentInfo = new StringBuilder();
            paymentInfo.AppendFormat("Product Name: {0}\n", this.ProductName);
            paymentInfo.AppendFormat("Product Price: {0}.lv\n", this.ProductPrice);

            return paymentInfo.ToString();
        }
    }
}
