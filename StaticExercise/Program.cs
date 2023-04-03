namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool? exit = null;
            while (exit == null)
            {
                Console.WriteLine("would you like to covert celcius to fahrenheit or fehrenheit to celcius?");
                var path = Console.ReadLine();
                switch (path.ToLower())
                {
                    case "yes":
                        Console.WriteLine("if you want to convert celcius to fahrenheit press 1\nif you like to convert fahrenheit to celcius press 2");
                        var path2 = int.Parse(Console.ReadLine());
                        switch (path2)
                        {
                            case 1: Console.WriteLine("enter celcius degree.");
                                var degree = double.Parse(Console.ReadLine());
                                double answer = TempConverter.CelToFah(degree);
                                Console.WriteLine($"{degree} celcius is {answer} degrees fahrenheit");
                                Console.WriteLine("press Enter to continue");
                                Console.ReadLine();
                                Console.Clear();
                                continue;

                            case 2: Console.WriteLine("enter fahrenheit degree.");
                                degree = double.Parse(Console.ReadLine());
                                answer = TempConverter.FahToCel(degree);
                                Console.WriteLine($"{degree} fahrenheit is {answer} degrees celcius");
                                Console.WriteLine("press Enter to continue");
                                Console.ReadLine();
                                Console.Clear();
                                continue;
                            default:
                                Console.WriteLine("not an option");
                                exit = true;
                                break;
                        }
                        break;
                    case "no":
                        exit = true;
                        break;
                }
            }




        }
    }
}
