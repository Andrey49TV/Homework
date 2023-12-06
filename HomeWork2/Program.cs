using System.Formats.Asn1;
using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        int ReadInt(string text)
        {
            System.Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }
        int[] GenerateArray(int size, int leftRange, int rightRange)
        {
            int[] tempArray = new int[size];
            Random rand = new Random();

            for (int i = 0; i < size; i++)
            {
                tempArray[i] = rand.Next(leftRange, rightRange + 1);
            }
            return tempArray;
        }
        void PrintArray(int[] array)
        {
            System.Console.WriteLine($"[{string.Join(", ", array)}]");
        }
         int CountDivBy7(int[] array)
        {
            int count = 0;
            for (int number = 0; number < array.Length; number++)
            {
                if (array[number] % 2 == 0)
                {
                    count++;
                }
              
            }
              return count;
        }
        int size = ReadInt("введите размер массива: ");
        int[] myArray = GenerateArray(size, 101, 999);
        PrintArray(myArray);

        int count = CountDivBy7(myArray);

        Console.WriteLine($"Количество трехзначных четных чисел равно = {count}");
    }
}
