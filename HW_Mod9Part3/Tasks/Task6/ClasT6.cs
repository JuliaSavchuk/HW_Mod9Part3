namespace HW_Mod9Part3
{
    public class DailyTemperature
    {
        public DateTime Date { get; set; }
        public double High { get; set; }
        public double Low { get; set; }

        public double Difference => High - Low;
    }
}
