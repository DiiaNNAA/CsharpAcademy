using System;

namespace CsharpAcademy.Assignment5
{
    public class Task1
    {

        static void Main()
        {
            Console.WriteLine("Enter the length of the array: ");
            string lengthInput = Console.ReadLine();

            if (int.TryParse(lengthInput, out int length) && length > 0)
            {
                int[] numbers = GenerateRandomArray(length);
                Console.WriteLine("Randomly generated array:");
                PrintArray(numbers);

                Console.WriteLine("Enter the index of the element: ");
                string indexInput = Console.ReadLine();

                if (int.TryParse(indexInput, out int index) && index >= 0 && index < length)
                {
                    int sum = SumDigits(numbers, index);
                    Console.WriteLine($"Sum of digits in element at index {index}: {sum}");
                }
                else
                {
                    Console.WriteLine("Invalid input or index out of range.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid length.");
            }
        }

        static int[] GenerateRandomArray(int length)
        {
            var random = new Random();
            int[] numbers = new int[length];

            for (int i = 0; i < length; i++)
            {
                numbers[i] = random.Next();
            }

            return numbers;
        }

        static void PrintArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.WriteLine(number);
            }
        }

        static int SumDigits(int[] array, int index)
        {
            int number = array[index];
            int sum = 0;

            while (number != 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }

            return sum;
        }

    }
}
