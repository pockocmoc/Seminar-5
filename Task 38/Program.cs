/*
  Задача 38: Задайте массив вещественных чисел. 
  Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] mass = new double[n];
double min = int.MaxValue;
double max = int.MinValue;
for (int i = 0; i < n; i++)
{
    Console.Write($" Введите {i} -й элемент(примеры записи: 1 или 1,5): ");
    mass[i] = Convert.ToDouble(Console.ReadLine());

    if (mass[i] < min)
        min = mass[i];

    if (mass[i] > max)
        max = mass[i];

}
Console.WriteLine($"\n Максимальный элемент: {max}\n Минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом: {max - min}");
