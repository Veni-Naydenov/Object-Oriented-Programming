using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal:ISound
    {
        private string name = null;
        private decimal age = 0;
        private string gender = null;

        public Animal(string name,
            decimal age,
            string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public decimal Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public string Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                this.gender = value;
            }
        }

        public abstract void ProduceSound();
        
        public override string ToString()
        {
            string animalInfo = string.Format(
                "Type Animal: {0}\n" +
                "Name: {1}\n" +
                "Age: {2}\n" +
                "Gender: {3}",
                this.GetType().Name,
                this.Name,
                this.Age,
                this.Gender);

            return animalInfo;
        }
    }
}
