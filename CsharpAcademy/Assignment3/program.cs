namespace CsharpAcademy.Assignment3
{
    //public class Task1
    //{

    //    static void Main()
    //    {
    //        Console.WriteLine("Enter a number: ");
    //        string input = Console.ReadLine();

    //        if (int.TryParse(input, out int number))
    //        {
    //            if (IsPrime(number))
    //            {
    //                Console.WriteLine("Is prime.");
    //            }
    //            else
    //            {
    //                Console.WriteLine("Is composite.");
    //            }
    //        }
    //        else
    //        {
    //            Console.WriteLine("Invalid input.");
    //        }
    //    }

    //    static bool IsPrime(int number)
    //    {
    //        if (number < 2)
    //        {
    //            return false;
    //        }

    //        for (int i = 2; i < number / 2 + 1; i++)
    //        {
    //            if (number % i == 0)
    //            {
    //                return false;
    //            }
    //        }

    //        return true;
    //    }

    //}







    //public class Task2
    //{
    //    static void Main()
    //    {
    //        Console.WriteLine("Enter a number: ");
    //        string input = Console.ReadLine();

    //        if (int.TryParse(input, out int number))
    //        {
    //            int divisorCount = CountDivisors(number);
    //            Console.WriteLine($"The number of divisors of {number} is: {divisorCount}");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Invalid input.");
    //        }
    //    }

    //    static int CountDivisors(int number)
    //    {
    //        int count = 0;

    //        for (int i = 1; i <= number; i++)
    //        {
    //            if (number % i == 0)
    //            {
    //                count++;
    //            }
    //        }

    //        return count;
    //    }
    //}






    //public class Task3
    //{
    //    static void Main()
    //    {
    //        Console.WriteLine("Enter the number of elements: ");
    //        string nInput = Console.ReadLine();

    //        if (int.TryParse(nInput, out int n) && n > 0)
    //        {
    //            double sum = 0;
    //            int count = 0;

    //            for (int i = 0; i < n; i++)
    //            {
    //                Console.WriteLine($"Enter number {i + 1}: ");
    //                string input = Console.ReadLine();

    //                if (double.TryParse(input, out double number))
    //                {
    //                    if (number > 0)
    //                    {
    //                        sum += number;
    //                        count++;
    //                    }
    //                }
    //                else
    //                {
    //                    Console.WriteLine("Invalid input.");
    //                }
    //            }

    //            if (count > 0)
    //            {
    //                double mean = sum / count;

    //                Console.WriteLine($"Sum of positive numbers: {sum}");
    //                Console.WriteLine($"Arithmetic mean of positive numbers: {mean}");
    //            }
    //            else
    //            {
    //                Console.WriteLine("No positive numbers were entered.");
    //            }
    //        }
    //        else
    //        {
    //            Console.WriteLine("Invalid input.");
    //        }
    //    }
    //}
















    //public class Task4
    //{
    //    static void Main()
    //    {
    //        Console.WriteLine("Enter a number: ");
    //        string input = Console.ReadLine();

    //        if (int.TryParse(input, out int number) && number >= 1)
    //        {
    //            PrintPyramid(number);
    //        }
    //        else
    //        {
    //            Console.WriteLine("Invalid input.");
    //        }
    //    }

    //    static void PrintPyramid(int number)
    //    {
    //        for (int i = 1; i <= number; i++)
    //        {
    //            for (int j = 1; j <= number - i; j++)
    //            {
    //                Console.Write(" ");
    //            }

    //            for (int j = 1; j <= 2 * i - 1; j++)
    //            {
    //                Console.Write("*");
    //            }

    //            Console.WriteLine();
    //        }
    //    }
    //}




    public class Task5
    {
        static void Main()
        {
            bool continuePlaying = true;

            while (continuePlaying)
            {
                Console.WriteLine("Enter the minimum number ");
                string minInput = Console.ReadLine();

                Console.WriteLine("Enter the maximum number ");
                string maxInput = Console.ReadLine();

                if (int.TryParse(minInput, out int minNumber) && int.TryParse(maxInput, out int maxNumber) && minNumber <= maxNumber)
                {
                    int randomNumber = GenerateRandomNumber(minNumber, maxNumber);
                    int attempts = 0;


                    while (true)
                    {
                        attempts++;

                        Console.WriteLine("Enter your guess: ");
                        string guessInput = Console.ReadLine();

                        if (int.TryParse(guessInput, out int guess))
                        {
                            if (guess == randomNumber)
                            {
                                Console.WriteLine($"You guessed the number in {attempts} attempts.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Wrong guess, try again.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.");
                        }
                    }

                    Console.WriteLine("Do you want to continue? Yes/No");
                    string continueInput = Console.ReadLine();

                    if (continueInput.ToLower() == "no")
                    {
                        continuePlaying = false;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
        }

        static int GenerateRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + 1);
        }
    }








}
