// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.WriteLine(" Введите любые числа через пробел:");
string number = Console.ReadLine();
int[] newarr = CopyArr(number);
Console.WriteLine($"В ряде чисел [{String.Join(" ", newarr)}] {Pozitiv(newarr)} положительных чисел");



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
int Pozitiv(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}