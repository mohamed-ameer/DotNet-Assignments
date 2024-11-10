namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentHourIn24_HourFormat = DateTime.Now.Hour;
            string greeting = currentHourIn24_HourFormat switch
            {
                int hour when hour > 5 && hour < 12 => "Good Morning",
                int hour when hour > 12 && hour < 17 => "Good Afternoon",
                int hour when hour > 17 && hour < 21 => "Good Evening",
                _ => "Good Night",
            };
            float userscore = default(float);
            float totalscore = default(float);
            float resultInPersentage = default(float);
            float resultInGpa = default(float);
            char exit = 'n';
            do
            {
                Console.WriteLine("Convert Your Grade To GPA");
                Console.WriteLine("=========================");
                Console.Write($"{greeting} Please enter your score:");
                userscore = float.Parse(Console.ReadLine());
                Console.Write("Please enter the total score:");
                totalscore = float.Parse(Console.ReadLine());
                resultInPersentage = (userscore / totalscore) * 100;
                resultInGpa = (resultInPersentage / 100) * 4;
                Console.WriteLine($"Your Score in % = {resultInPersentage}");
                Console.WriteLine($"Your Score in GPA = {resultInGpa}");
                Console.Write("Continue (y/n):");
                exit = char.Parse(Console.ReadLine());
            }while(exit != 'n');
        }
    }
}
