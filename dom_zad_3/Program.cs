// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


Console.Clear();
const int LEFT_RANGE = -20;
const int RIGHT_RANGE = 20;
int num = inputNumber();
double[] myArray = FillArray(num, LEFT_RANGE, RIGHT_RANGE);
print(myArray);
print_difference(myArray);






void print(double[] arr)
{
    System.Console.Write($"[{String.Join("; ", arr)}]");
    System.Console.WriteLine();
}


double[] FillArray(int num, int LEFT_RANGE, int RIGHT_RANGE)
{
    double[] arr = new double[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = Math.Round((new Random().Next(LEFT_RANGE, RIGHT_RANGE) + new Random().NextDouble()), 3);
    }
    return arr;
}


int inputNumber()
{
    int number;
    string text;

    while (true)
    {
        Console.Write("Введите количество элементов массива: ");
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}

void print_difference(double[] arr)
{
    System.Console.WriteLine("Максимальный элемент массива:");
    System.Console.WriteLine(arr.Max());
    System.Console.WriteLine("Минимальный элемент массива:");
    System.Console.WriteLine(arr.Min());
    System.Console.WriteLine("Разница:");
    System.Console.WriteLine($"{arr.Max()} - {arr.Min()} = {Math.Round(arr.Max() - arr.Min(), 3)}");
}



