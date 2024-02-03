namespace GA_Condition_Salvador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Checking Conditions");

            int number = 5;
            if (number == 5)
            {
                Console.WriteLine("Number is equal to 5");
            }
            if (number > 5)
            {
                Console.WriteLine("Number is greater than 5");
            }
            else
            {
                Console.WriteLine("Number is not greater than 5");
            }
            if (number ==5)
            {
                Console.WriteLine("Number is 5");
            }
            else if (number == 5)
            {
                Console.WriteLine("Number is greater than 5 ");
            }
            else
            {
                Console.WriteLine("Number is less than");
            }
            int temprature = 75;
            string weatherInfo = "";

            if (temprature > 80)
            {
                weatherInfo = "It's a hot day!";
            }
            else if (temprature > 60)
            {
                weatherInfo = "It's a pleasant day.";
            }
            else
            {
                weatherInfo = "Its's a bit chilly.";
            }
            Console.WriteLine(weatherInfo);
        }
    }
}
