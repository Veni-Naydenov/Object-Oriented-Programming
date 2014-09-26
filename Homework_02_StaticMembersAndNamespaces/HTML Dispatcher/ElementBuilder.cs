namespace HtmlDispatcher
{
    using System;
    using System.Text;

    public class ElementBuilder
    {
        private string elementName = null;
        private string atributeName = null;
        private string atributeValue = null;
        private StringBuilder element;
        private string content = null;


        public ElementBuilder(string nameOfElement)
        {
            this.ElementName = nameOfElement;
            this.element = new StringBuilder();
            element.AppendFormat("<{0} ", this.ElementName);
        }

        public string Content
        {
            get
            {
                return this.content;
            }
            private set
            {
                this.content = value;
            }
        }

        public string ElementName
        {
            get
            {
                return this.elementName;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Empty or null atribute Element Name");
                }
                this.elementName = value;
            }
        }

        public string AtributeValue
        {
            get
            {
                return this.atributeValue;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Empty or null atribute Value");
                }
                this.atributeValue = value;
            }
        }

        public string AtributeName
        {
            get
            {
                return this.atributeName;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Empty or null atribute Name");
                }
                this.atributeName = value;
            }
        }

        public void AddAtribute(string attribute, string value)
        {
            if (this.element.ToString()[element.Length - 1] == '>')
            {
                element.Remove(element.Length - 1, 1);
                element.Append(' ');
            }

            this.AtributeName = attribute;
            this.AtributeValue = value;
            element.AppendFormat("{0}=\"{1}\"/>", this.AtributeName, this.AtributeValue);
        }

        public void AddContent(string content)
        {
            if (this.element.ToString().Substring(element.Length - 2, 2) == "/>")
            {
                element.Remove(element.Length - 2, 2);
                element.Append(">");
            }

            string closingTag = "</" + this.elementName + ">";

            if (this.element.ToString().Contains(closingTag))
            {
                element.Replace(closingTag, "");
            }

            this.element.AppendFormat("{0}</{1}>", content, this.elementName);
        }

        public override string ToString()
        {
            return this.element.ToString();
        }

        public static string operator *(ElementBuilder element, int n)
        {
            StringBuilder multipliedElement = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                multipliedElement.AppendLine(element.ToString());
            }

            return multipliedElement.ToString();
        }
    }
}
