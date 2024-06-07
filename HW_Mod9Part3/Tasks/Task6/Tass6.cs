namespace HW_Mod9Part3
{
    internal class Tass6
    {
        public static void Task6()
        {
            DailyTemperature[] temperatures = {
            new DailyTemperature { Date = new DateTime(2023, 1, 1), High = 10, Low = 2 },
            new DailyTemperature { Date = new DateTime(2023, 1, 2), High = 15, Low = 3 },
            new DailyTemperature { Date = new DateTime(2023, 1, 3), High = 8, Low = 5 }
        };

            var maxDifferenceDay = temperatures[0];
            foreach (var temp in temperatures)
            {
                if (temp.Difference > maxDifferenceDay.Difference)
                {
                    maxDifferenceDay = temp;
                }
            }

            Console.WriteLine($"Day with max temperature difference: {maxDifferenceDay.Date.ToShortDateString()} with difference of {maxDifferenceDay.Difference} degrees.");
        }
    }
}
