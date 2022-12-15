// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.Clear();
const int LEFT_RANGE = -20;
const int RIGHT_RANGE = 20;
int num = inputNumber();
int odd_index_numbers;
print(FillArray(num, out odd_index_numbers, LEFT_RANGE, RIGHT_RANGE));
System.Console.WriteLine($"Сумма чисел на нечетных позициях: {odd_index_numbers}");


void print(int[] arr)
{
    System.Console.Write($"[{String.Join(", ", arr)}]");
    System.Console.WriteLine();
}

int[] FillArray(int num, out int odd_index_numbers, int LEFT_RANGE, int RIGHT_RANGE)
{
    odd_index_numbers = 0;
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = new Random().Next(LEFT_RANGE, RIGHT_RANGE);
        if (i % 2 == 1)
            odd_index_numbers += arr[i];
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

