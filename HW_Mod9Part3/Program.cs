namespace HW_Mod9Part3
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("-----Task 1-----\n");
            int number = 13;
            Console.WriteLine($"{number} is Fibonacci: {number.IsFibonacci()}");

            number = 15;
            Console.WriteLine($"{number} is Fibonacci: {number.IsFibonacci()}");

            Console.WriteLine("\n-----Task 2-----\n\n");
            string sentence = "Hello, how are you?";
            Console.WriteLine($"Word count: {sentence.WordCount()}");

            Console.WriteLine("\n-----Task 3-----\n\n");
            Console.WriteLine($"Length of last word: {sentence.LengthOfLastWord()}");

            Console.WriteLine("\n-----Task 4-----\n\n");
            string input = "{}[]";
            Console.WriteLine($"Brackets in '{input}' are valid: {input.AreBracketsValid()}");

            input = "[{]}";
            Console.WriteLine($"Brackets in '{input}' are valid: {input.AreBracketsValid()}");

            Console.WriteLine("\n-----Task 5-----\n\n");
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = numbers.Filter(x => x % 2 == 0);
            Console.WriteLine($"Filtered even numbers: {string.Join(", ", evenNumbers)}");

            Console.WriteLine("\n-----Task 6-----\n\n");
            Tass6.Task6();

            Console.WriteLine("\n-----Task 7-----\n\n");
            Tass7.Task7();

        }
    }
}