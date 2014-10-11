namespace StringDisperser
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    class StringDisperser : ICloneable, IComparable<StringDisperser>, IEnumerable<char>
    {
        private string fullString = null;

        public StringDisperser(params string[] strings)
        {
            this.FullString = string.Join("", strings);
        }

        public string FullString
        {
            get
            {
                return this.fullString;
            }
            set
            {
                this.fullString = value;
            }
        }

        #region methods

        public override bool Equals(object obj)
        {
            StringDisperser stringDisperser = obj as StringDisperser;

            if (stringDisperser == null)
            {
                return false;
            }

            if (!Object.Equals(this.FullString, stringDisperser.FullString))
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            int hashCode = (this.FullString ?? "").GetHashCode();

            return hashCode;
        }

        public StringDisperser Clone()
        {
            return new StringDisperser(this.FullString);

        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            foreach (var letter in this.FullString)
            {
                result.AppendFormat("{0} ", letter);
            }

            return result.ToString();
        }

        public int CompareTo(StringDisperser other)
        {
            int compareResult = string.Compare(this.FullString, other.FullString);

            if (compareResult != 0)
            {
                return compareResult;
            }

            return 0;
        }

        public IEnumerator<char> GetEnumerator()
        {
            for (int i = 0; i < this.fullString.Length; i++)
            {
                yield return this.FullString[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        #endregion

        #region operators

        public static bool operator ==(StringDisperser stringDisperser, StringDisperser otherString)
        {
            return StringDisperser.Equals(stringDisperser, otherString);
        }

        public static bool operator !=(StringDisperser stringDisperser, StringDisperser otherString)
        {
            return !StringDisperser.Equals(stringDisperser, otherString);
        }

        #endregion
    }
}
