/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
*/
using System.Diagnostics;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите элементы массива, разделенные пробелом:");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');
        double[] array = new double[inputArray.Length];

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (!double.TryParse(inputArray[i].Replace('.', ','), out array[i]))
            {
                Console.WriteLine("В массиве должны быть вещественные числа");
                return;
            }
        }

        MaxMinFunc(array);
    }

    static void MaxMinFunc(double[] array)
    {
        double max_i = array[0];
        double min_i = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max_i)
            {
                max_i = array[i];
            }
            else if (array[i] < min_i)
            {
                min_i = array[i];
            }
        }

        double result = max_i - min_i;
        Console.WriteLine("Разница между максимальным и минимальным числами: " + result);
    }
}
