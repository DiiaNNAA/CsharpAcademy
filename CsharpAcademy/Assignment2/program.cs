namespace CsharpAcademy.Assignment2
{

    //public class Task2
    //{
    //    public static void Main()
    //    {
    //        Console.WriteLine("Enter the temperature in Celsius: ");
    //        string input = Console.ReadLine();

    //        if (int.TryParse(input, out int temperature))
    //        {
    //            if (temperature < 0)
    //            {
    //                Console.WriteLine("Freezing");
    //            }
    //            else if (temperature >= 0 && temperature <= 30)
    //            {
    //                Console.WriteLine("Good weather");
    //            }
    //            else
    //            {
    //                Console.WriteLine("It's hot");
    //            }
    //        }
    //        else
    //        {
    //            Console.WriteLine("Invalid input. Please enter a valid temperature.");
    //        }
    //    }
    //}





    //public class Task3
    //{
    //    public static void Main()
    //    {
    //        string[] choices = { "rock", "paper", "scissors" };
    //        var rand = new Random();
    //        int computerChoiceIndex = rand.Next(0, 3);
    //        string computerChoice = choices[computerChoiceIndex];

    //        Console.WriteLine("Enter your choice (rock, paper, or scissors): ");
    //        string userChoice = Console.ReadLine().ToLower();

    //        Console.WriteLine("Your choice: " + userChoice);
    //        Console.WriteLine("Computer's choice: " + computerChoice);

    //        if (userChoice == computerChoice)
    //        {
    //            Console.WriteLine("It's a tie");
    //        }
    //        else if (
    //            (userChoice == "rock" && computerChoice == "scissors") ||
    //            (userChoice == "paper" && computerChoice == "rock") ||
    //            (userChoice == "scissors" && computerChoice == "paper")
    //        )
    //        {
    //            Console.WriteLine("You win");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Computer wins");
    //        }
    //    }
    //}



    //public class Task4
    //{
    //    static void Main()
    //    {
    //        Console.WriteLine("Enter your year of birth: ");
    //        string input = Console.ReadLine();

    //        if (int.TryParse(input, out int yearOfBirth))
    //        {
    //            int chineseYear = (yearOfBirth - 4) % 12;

    //            Console.WriteLine($"You were born in the year of the {GetChineseZodiac(chineseYear)}.");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Invalid input.");
    //        }
    //    }

    //    static string GetChineseZodiac(int year)
    //    {
    //        string[] chineseZodiacs = {
    //        "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake",
    //        "Horse", "Goat", "Monkey", "Rooster", "Dog", "Pig"
    //    };

    //        return chineseZodiacs[year];
    //    }
    //}






}