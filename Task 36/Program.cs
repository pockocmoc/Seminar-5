/*
   Задача 36: Задайте одномерный массив, заполненный случайными числами. 
   Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
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
            arr[i] = rnd.Next(-99, 100);
        }

        var result = string.Join(", ", arr);
        Console.WriteLine($"[{result}]");


        var odd = arr.Where((element, index) => index % 2 != 0);
        Console.WriteLine("Сумма элементов на нечётных позициях: {0}.", odd.Sum());
    }
}