namespace StudentClass
{
    using System;

    public class PropertyChangedEventArgs : EventArgs
    {
        private dynamic oldValue;
        private dynamic newValue;
        private string propName;

        public PropertyChangedEventArgs(string propertyName, dynamic oldValue, dynamic newValue)
        {
            this.propName = propertyName;
            this.oldValue = oldValue;
            this.newValue = newValue;
        }

        public string PropertyName
        {
            get
            {
                return this.propName;
            }
            private set
            {
                this.propName = value;
            }
        }

        public dynamic OldValue
        {
            get
            {
                return this.oldValue;

            }
        }

        public dynamic NewValue
        {
            get
            {
                return this.newValue;
            }
        }
    }
}
