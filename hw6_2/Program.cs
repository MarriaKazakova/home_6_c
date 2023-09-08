/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
using System.Diagnostics;
class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int[] lst = Enumerable.Range(0, 10).Select(_ => rand.Next(0, 100)).ToArray();
        Console.WriteLine("Array: " + string.Join(", ", lst));
        int sum = 0;
        for (int i = 1; i < lst.Length; i += 2)
        {
            sum += lst[i];
        }
        Console.WriteLine("Сумма элементов на нечетных позициях: " + sum);
    }
}
