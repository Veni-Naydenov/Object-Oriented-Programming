namespace LaptopShop
{

    class Screen
    {
        private string type;
        private uint width = 0;
        private uint height = 0;

        public Screen(string type)
            : this(type, 1366, 768)
        {

        }

        public Screen(string type, uint width, uint height)
        {
            this.type = type;
            this.width = width;
            this.height = height;
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

        public uint Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }

        public uint Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }
    }
}
