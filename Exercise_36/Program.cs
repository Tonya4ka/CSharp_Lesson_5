// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.Write("Type size of the array: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = new int[size];
FillArray(array);
PrintArray(array);
Console.WriteLine($"The array has {array.Length} numbers, the sum of elements located at odd indices is {SumOddPositionNumbers(array)}");

void FillArray(int[] array)
{
    Random RandGen = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = RandGen.Next(1,10);
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

int SumOddPositionNumbers(int[] array)
{
    int sum = 0;
    for(int i=1; i<array.Length; i+=2)
       sum = sum + array[i];
    return sum;
}
