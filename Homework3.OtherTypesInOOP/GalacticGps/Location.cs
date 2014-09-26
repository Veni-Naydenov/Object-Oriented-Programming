using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGps
{
    public struct Location
    {
        private double latitude;
        private double longitude;
        private Planet planet;

        public Location(double latitude, double longitude, Planet planet)
            : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.planet = planet;

        }

        public double Latitude
        {
            get
            {
                return this.latitude;
            }
            set
            {
                this.latitude = value;
            }
        }

        public double Longitude
        {
            get
            {
                return this.longitude;
            }
            set
            {
                this.longitude = value;
            }
        }

        public Planet Planet
        {
            get
            {
                return this.planet;
            }
            private set
            {
                this.planet = value;
            }
        }

        public override string ToString()
        {
            string result = string.Format("{0:f6}, {1:f6} - {2}",
                this.Latitude, this.Longitude, this.planet);

            return result;
        }
    }
}
