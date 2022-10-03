// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
Console.Write("Type size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArray(array);
PrintArray(array);
Console.WriteLine($"The array has {array.Length} numbers, {EvenNumbers(array)} are even");

void FillArray(int[] array)
{
    Random RandGen = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = RandGen.Next(100,1000);
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("]");
}

int EvenNumbers(int[] array)
{
    int count = 0;
    for(int i=0; i<array.Length; i++)
    {
        if (array[i]%2 == 0)
           count++;
    }
    return count;
}