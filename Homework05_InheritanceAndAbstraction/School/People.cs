namespace School
{
    public abstract class People : Detail
    {

        private string name = null;

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
    }
}
