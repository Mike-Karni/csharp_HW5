/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/
Console.WriteLine("Введите длину массива ");
int Length = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[Length];
FillArray(numbers);
PrintArray(numbers);
Max(numbers);
Console.WriteLine("Максимальный элемент массива = " + Max(numbers));
Min(numbers);
Console.WriteLine("Минимальный элемент массива = " + Min(numbers));
double result = Max(numbers) - Min(numbers);
Console.WriteLine("Разница между максимальным и минимальным элементом массива = " + result);


void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}
void PrintArray(double[] array1)

{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write(array1[i] + " ");

    }
    Console.WriteLine();
}
double Max(double[] numbers)
{
    double maxValue = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > maxValue)
        {
            maxValue = numbers[i];
        }
    }
    return maxValue;
}
double Min(double[] numbers)
{
    double minValue = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < minValue)
        {
            minValue = numbers[i];
        }
    }
    return minValue;
}