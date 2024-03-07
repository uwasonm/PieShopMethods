namespace PieShopMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount = 1234;
            int months = 12;

            int yearlyWage = Utilities.CalculateYearlyWage(amount, months);
             Console.WriteLine($"YearlyWage : {yearlyWage}");
            Console.ReadLine();
        }

    }
}
