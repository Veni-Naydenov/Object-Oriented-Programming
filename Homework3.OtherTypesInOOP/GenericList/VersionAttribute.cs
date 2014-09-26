namespace GenericList
{
    using System;

    [System.AttributeUsage
        (System.AttributeTargets.Class
        | System.AttributeTargets.Struct
        | System.AttributeTargets.Method
        | System.AttributeTargets.Enum
        | System.AttributeTargets.Interface,
                        AllowMultiple = true)]

    public class VersionAttribute : System.Attribute
    {
        private uint major;
        private uint minor;

        public string FullVersion
        {
            get
            {
                return String.Format("{0}.{1}", major, minor);
            }
        }

        public VersionAttribute(string version)
        {
            string[] elements = version.Split('.');
            this.major = uint.Parse(elements[0]);
            this.minor = uint.Parse(elements[1]);
        }
    }
}
