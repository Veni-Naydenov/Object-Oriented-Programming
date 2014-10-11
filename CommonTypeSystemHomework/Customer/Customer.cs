namespace Customer
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Customer : ICloneable, IComparable<Customer>
    {
        private string firstName = null;
        private string middleName = null;
        private string lastName = null;
        private long id = 0;
        private string address = null;
        private string mobilePhone = null;
        private string email = null;
        private IList<Payment> payments;
        private Customers customerType;

        public Customer(string firstName,
            string middleName,
            string lastName,
            long id,
            string address,
            string mobilePhone,
            string email,
            IList<Payment> payments,
            Customers customerType)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Id = id;
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Payments = payments;
            this.CustomerType = customerType;
        }

        #region properties

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public long Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }

        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }
            set
            {
                this.mobilePhone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public IList<Payment> Payments
        {
            get
            {
                return this.payments;
            }
            set
            {
                this.payments = value;
            }
        }

        public Customers CustomerType
        {
            get
            {
                return this.customerType;
            }
            set
            {
                this.customerType = value;
            }
        }

        #endregion

        #region methods

        public override bool Equals(object obj)
        {
            Customer customer = obj as Customer;

            if (customer == null)
            {
                return false;
            }

            if (!Object.Equals(this.FirstName, customer.FirstName))
            {
                return false;
            }

            if (!Object.Equals(this.MiddleName, customer.MiddleName))
            {
                return false;
            }

            if (!Object.Equals(this.LastName, customer.LastName))
            {
                return false;
            }

            if (this.Id != customer.Id)
            {
                return false;
            }

            if (!Object.Equals(this.Address, customer.Address))
            {
                return false;
            }

            if (!Object.Equals(this.MobilePhone, customer.MobilePhone))
            {
                return false;
            }

            if (!Object.Equals(this.Email, customer.Email))
            {
                return false;
            }

            if (this.Payments != customer.Payments)
            {
                return false;
            }

            if (this.CustomerType != customer.CustomerType)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            int hashCode = this.FirstName.GetHashCode() +
                this.MiddleName.GetHashCode() +
                this.LastName.GetHashCode() +
                this.Id.GetHashCode() +
                (this.Address ?? "").GetHashCode() +
                (this.MobilePhone ?? "").GetHashCode() +
                (this.Email ?? "").GetHashCode() +
                this.Payments.GetHashCode() +
                this.CustomerType.GetHashCode();

            return hashCode;
        }

        public Customer Clone()
        {
            return new Customer(this.FirstName,
                this.MiddleName,
                this.LastName,
                this.Id,
                this.Address,
                this.MobilePhone,
                this.Email,
                this.Payments,
                this.CustomerType);
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public int CompareTo(Customer other)
        {
            int firstNamesCompareResult = string.Compare(this.FirstName, other.FirstName);
            int middleNamesCompareResult = string.Compare(this.MiddleName, other.MiddleName);
            int lastNamesCompareResult = string.Compare(this.LastName, other.LastName);

            if (firstNamesCompareResult != 0)
            {
                return firstNamesCompareResult;
            }

            if (middleNamesCompareResult != 0)
            {
                return middleNamesCompareResult;
            }

            if (lastNamesCompareResult != 0)
            {
                return lastNamesCompareResult;
            }

            if (this.Id != other.Id)
            {
                return this.Id > other.Id ? 1 : -1;
            }

            return 0;
        }

        public override string ToString()
        {
            StringBuilder customerInfo = new StringBuilder();
            customerInfo.AppendFormat("First Name: {0}\n", this.FirstName);
            customerInfo.AppendFormat("Middle Name: {0}\n", this.MiddleName);
            customerInfo.AppendFormat("Last Name: {0}\n", this.LastName);
            customerInfo.AppendFormat("Id: {0}\n", this.Id);
            customerInfo.AppendFormat("Address: {0}\n", this.Address);
            customerInfo.AppendFormat("Mobile Phone: {0}\n", this.MobilePhone);
            customerInfo.AppendFormat("Email: {0}\n", this.Email);

            customerInfo.AppendFormat("Payments: \n");
            foreach (var payment in payments)
            {
                customerInfo.AppendFormat(payment.ToString());
            }

            customerInfo.AppendFormat("Customer Type: {0}\n", this.CustomerType);

            return customerInfo.ToString();
        }

        #endregion

        #region operators

        public static bool operator ==(Customer customer, Customer otherCustomer)
        {
            return Customer.Equals(customer, otherCustomer);
        }

        public static bool operator !=(Customer customer, Customer otherCustomer)
        {
            return !Customer.Equals(customer, otherCustomer);
        }

        #endregion
    }
}
