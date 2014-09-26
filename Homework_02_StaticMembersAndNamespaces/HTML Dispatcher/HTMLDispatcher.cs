namespace HtmlDispatcher
{
    public static class HTMLDispatcher
    {
        public static string CreateImage(string imgSource, string alt, string title)
        {
            ElementBuilder image = new ElementBuilder("img");
            image.AddAtribute("src", imgSource);
            image.AddAtribute("alt", alt);
            image.AddAtribute("title", title);

            return image.ToString();
        }

        public static string CreateURL(string url, string title, string text)
        {
            ElementBuilder hyperlink = new ElementBuilder("a");
            hyperlink.AddAtribute("href", url);
            hyperlink.AddAtribute("title", title);
            hyperlink.AddContent(text);

            return hyperlink.ToString();
        }

        public static string CreateInput(string type, string name, string value)
        {
            ElementBuilder input = new ElementBuilder("input");
            input.AddAtribute("type", type);
            input.AddAtribute("name", name);
            input.AddAtribute("value", value);

            return input.ToString();
        }
    }
}
