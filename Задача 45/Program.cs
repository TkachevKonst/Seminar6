// Написать программу которая копирует массив поэлементно
Console.Clear();
Console.WriteLine("Задайте массив, вводите числа через пробел :");
string newarr = Console.ReadLine();
Console.WriteLine($"[{String.Join(" ",CopyArr(newarr))}] копия массива [{newarr}]");
int[] CopyArr(string arr)
{
    string[] array = arr.Split(" ");
    int[] copy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copy[i] = int.Parse(array[i]);
    }
    return copy;
}