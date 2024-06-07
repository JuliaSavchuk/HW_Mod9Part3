namespace HW_Mod9Part3
{
    public static class Task1
    {
        public static bool IsFibonacci(this int number)
        {
            if (number < 0) return false;
            int a = 0, b = 1, c = 1;
            while (c < number)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c == number || number == 0;
        }
    }
}
