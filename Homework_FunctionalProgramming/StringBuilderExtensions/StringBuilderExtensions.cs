namespace StringBuilderExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    public static class StringBuilderExtensions
    {
        public static string Substring(this StringBuilder builder, int startIndex, int length)
        {
            // string substringValue = bilder.ToString().Substring(startIndex,length);
            int endIndex = startIndex + length;

            if (startIndex < 0 || startIndex > builder.Length)
            {
                throw new IndexOutOfRangeException(String.Format("Start index must be bigger than 0 and less than {0}", builder.Length));
            }

            if (endIndex > builder.Length || endIndex < 0)
            {
                throw new IndexOutOfRangeException(String.Format("(Start index + length) must be bigger than 0  and less than {0}", builder.Length));
            }

            StringBuilder substringValue = new StringBuilder();

            for (int i = startIndex; i < endIndex; i++)
            {
                substringValue.Append(builder[i]);
            }

            return substringValue.ToString();
        }

        public static StringBuilder RemoveText(this StringBuilder builder, string text)
        {
            string str = Regex.Replace(builder.ToString(), text, "", RegexOptions.IgnoreCase);
            builder.Clear();
            builder.Append(str);

            return builder;
        }

        public static StringBuilder AppendAll<T>(this StringBuilder builder, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                builder.Append(item.ToString());
            }

            return builder;
        }

        public static StringBuilder AppendAll<T>(this StringBuilder builder, IEnumerable<T> items, string delimiter)
        {
            foreach (var item in items)
            {
                builder.AppendFormat("{0}{1}", delimiter, item.ToString());
            }

            return builder;
        }
    }
}
