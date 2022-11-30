Console.Clear();

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] GetArray(int size)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(100, 1000);
//     }
//     return result;
// }
// int SumEvenNumbers(int[] getarray)
// {
//     int sum = 0;
//     for (int i = 0; i < getarray.Length; i++)
//     {
//         if (getarray[i] % 2 == 0)
//         {
//             sum++;
//         }
//     }
//     return sum;
// }
// Console.WriteLine($"Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве");
// Console.Write($"введите размер массива: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = GetArray(num);
// Console.WriteLine($"[{string.Join(", ", array)}]) -> {SumEvenNumbers(array)}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int[] GetArray(int size)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(-99, 100);
//     }
//     return result;
// }
// int SumOddNumbers(int[] getarray)
// {
//     int sum = 0;
//     for (int i = 1; i < getarray.Length; i += 2)
//     {
//         sum += getarray[i];
//     }
//     return sum;
// }
// Console.WriteLine($"Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях");
// Console.Write($"Введите размер массива: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int [] array = GetArray(num);
// Console.WriteLine($"[{String.Join(", ", array)}] -> {SumOddNumbers(array)}");



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// double[] GetArray(int size)
// {
//     double[] result = new double[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = Convert.ToDouble(new Random().Next(-9999, 10000)) / 100;
//     }
//     return result;
// }

// double Difference(double[] getarray)
// {
//     double dif = 0;
//     double max = getarray[0];
//     double min = getarray[0];
//     for (int i = 0; i < getarray.Length; i++)
//     {
//         if (getarray[i] > max)
//         {
//             max = getarray[i];
//         }
//         else if (getarray[i] < min)
//         {
//             min = getarray[i];
//         }
//     }
//     if (max > 0 && min <= 0)
//     {
//         dif = max + Math.Abs(min);
//     }    
//     else if (max >= 0 && min >= 0)
//     {
//         dif = max - min;
//     }
//     else
//     {
//         dif = Math.Abs(min) + max;
//     }
//     return dif;
// }

// Console.WriteLine($"Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива");
// Console.Write($"Задайте размер массива: ");
// int num = Convert.ToInt32(Console.ReadLine());
// double[] array = GetArray(num);
// Console.WriteLine($"[{String.Join(", ", array)}] -> {Math.Round(Difference(array), 2)}");