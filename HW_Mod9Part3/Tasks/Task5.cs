namespace HW_Mod9Part3
{
    public static class Task5
    {
        public static int[] Filter(this int[] array, Predicate<int> predicate)
        {
            return array.Where(item => predicate(item)).ToArray();
        }
    }
}
