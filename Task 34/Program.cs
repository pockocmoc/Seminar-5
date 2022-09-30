/*
   Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
   Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите размерность массива:");
        int demension = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        int[] arr = new int[demension];

        for (int i = 0; i < demension; i++)
        {
            arr[i] = rnd.Next(99, 1000);
        }

        var result = string.Join(", ", arr);
        Console.WriteLine($"[{result}]");


        var posNums = arr.Where(n => n % 2 == 0);
        Console.WriteLine("Количество чётных чисел в массиве: {0}", posNums.LongCount());
    }
}