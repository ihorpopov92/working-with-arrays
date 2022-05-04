using System;

namespace Working_with_arrays
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, my friend. Please enter length of array:");
            int lengthArray = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();

            int indexEven = 0;
            int indexOdd = 0;

            string[] evenNums = new string[lengthArray];
            string[] oddNums = new string[lengthArray];
            int[] randomNums = new int[lengthArray];

            for (int i = 0; i < lengthArray; i++)
            {
                randomNums[i] = random.Next(1, 26);
            }

            foreach (int num in randomNums)
            {
                if (num % 2 == 0)
                {
                    evenNums[indexEven++] = Convert.ToString(num).Replace("26", "z").Replace("24", "x").Replace("22", "v").Replace("20", "t")
                        .Replace("18", "r").Replace("16", "p").Replace("14", "n").Replace("12", "l").Replace("10", "J").Replace("8", "H")
                        .Replace("6", "f").Replace("4", "D").Replace("2", "b");
                }
                else if (num % 2 != 0)
                {
                    oddNums[indexOdd++] = Convert.ToString(num).Replace("25", "y").Replace("23", "w").Replace("21", "u").Replace("19", "s")
                        .Replace("17", "q").Replace("15", "o").Replace("13", "m").Replace("11", "k").Replace("9", "I").Replace("7", "g")
                        .Replace("5", "E").Replace("3", "c").Replace("1", "A");
                }
            }

            string strEvenNums = string.Join(" ", evenNums);

            string strOddNums = string.Join(" ", oddNums);

            Console.WriteLine($"array #1 - {strEvenNums}");
            Console.WriteLine($"array #2 - {strOddNums}");
        }
    }
}
