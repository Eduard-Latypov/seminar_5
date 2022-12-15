// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.Clear();
const int LEFT_RANGE = 100;
const int RIGHT_RANGE = 1000;
int num = inputNumber();
int even_numbers = 0;
print(FillArray(num, out even_numbers, LEFT_RANGE, RIGHT_RANGE));
System.Console.WriteLine($"Количество четный чисел в массиве: {even_numbers}");


void print(int[] arr)
{
    System.Console.Write($"[{String.Join(", ", arr)}]");
    System.Console.WriteLine();
}

int[] FillArray(int num, out int even_numbers, int LEFT_RANGE, int RIGHT_RANGE)
{
    even_numbers = 0;
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = new Random().Next(LEFT_RANGE, RIGHT_RANGE);
        if (arr[i] % 2 == 0)
            even_numbers += 1;
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


