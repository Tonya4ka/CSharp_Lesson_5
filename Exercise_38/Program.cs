// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива
// [3 7 22 2 78] -> 76

Console.Clear();
Console.Write("Type size of the array: ");
int size = int.Parse(Console.ReadLine()!);
double[] array = new double[size];
FillArray(array);
PrintArray(array);

Console.WriteLine($"The difference between maximum and minimum is {MaxMinDif(array)}");


void FillArray(double[] array)
{
    Random RandGen = new Random();
    double lbound = 0;
    double ubound = 100;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (ubound-lbound) * Convert.ToDouble(RandGen.NextDouble());
    }
}

void PrintArray(double[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("]");
}

double MaxMinDif(double[] array)
{
    double min = Int32.MaxValue;
    double max = Int32.MinValue;

    for(int i=0; i<array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }  
    return (max - min);
}

