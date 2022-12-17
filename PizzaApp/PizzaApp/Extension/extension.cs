namespace PizzaApp.extension
{
    public static class extension
    {
        public static string PremierletttreMaj(string mots)
        {
            if (string.IsNullOrEmpty(mots))
            {
                return mots;
            }

            string formatmots = mots.ToLower();
            formatmots = formatmots.Substring(0, 1).ToLower() + formatmots.Substring(1, formatmots.Length - 1);
            return formatmots;
        }
    }

}
