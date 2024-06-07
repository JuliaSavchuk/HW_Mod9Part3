namespace HW_Mod9Part3
{
    public static class Task3
    {
        public static int LengthOfLastWord(this string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return 0;
            var words = str.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length > 0 ? words[^1].Length : 0;
        }
    }
}
