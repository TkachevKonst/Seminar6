// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
Console.Write("Введите коэффициент k1 и константу b1 для первого уровнения через пробел:");
string line1 = Console.ReadLine();
Console.Write("Введите коэффициент k2 и константу b2 для второго уровнения через пробел:");
string line2 = Console.ReadLine();
double[] lin1 = GetArray(line1);
double[] lin2 = GetArray(line2);
double[] inter = Inter (lin1, lin2);
if (Parallel(lin1, lin2))
{
    Console.Write($"Координаты точки пересечения линий с уравнениями y={lin1[0]}*x+{lin1[1]} и y={lin2[0]}*x+{lin2[1]}:");
    PrintArray(inter);
}





bool Parallel(double[] arr1, double[] arr2)
{
    if (arr1[0] == arr2[0])
    {
        if (arr1[1] == arr2[1])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        Console.WriteLine("Прямые паралельны точек пересечения нет");
        return false;
    }
    return true;
}
double[] GetArray(string arr)
{
    string[] array = arr.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    double[] num = new double[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        num[i] = double.Parse(array[i]);
    }
    return num;
}
double[] Inter(double[] arr1, double[] arr2)
{
    double[] arr = new double[2];
    arr[0] = (arr1[1] - arr2[1]) / (arr2[0] - arr1[0]);
    arr[1] = arr1[0] * arr[0] + arr1[1];
    return arr;
}
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]:f2}");
    }
}