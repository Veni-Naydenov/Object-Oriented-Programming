namespace StudentClass
{
    class Student
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string name = null;
        private ushort age = 0;

        public Student(string name, ushort age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                EventHandler("Name", this.name, value);
                this.name = value;
            }
        }

        public ushort Age
        {
            get
            {
                return this.age;
            }
            set
            {
                EventHandler("Age", this.age, value);
                this.age = value;
            }
        }

        private void EventHandler(string prop, dynamic old, dynamic newValue)
        {
            if (old != newValue)
            {
                PropertyChangedEventArgs args = new PropertyChangedEventArgs(prop, old, newValue);
                PropertyChanged(this, args);
            }
        }
    }
}
