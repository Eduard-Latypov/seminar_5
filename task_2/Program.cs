// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


Console.Clear();
const int SIZE = 20;
const int LEFT_RANGE = -10;
const int RIGHT_RANGE = 10;
int num = inputNumber();
int[] myArray = GetArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
System.Console.WriteLine();
System.Console.WriteLine(NumberInArray(myArray, num));






int[] GetArray(int SIZE, int LEFT_RANGE, int RIGHT_RANGE)
{
    int[] arr = new int[SIZE];
    for (int i = 0; i < SIZE; i++)
    {
        arr[i] = new Random().Next(LEFT_RANGE, RIGHT_RANGE + 1);
    }
    foreach (var item in arr)
    {
        System.Console.Write(item + " ");
    }
    return arr;
}


string NumberInArray(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
            return "да, массив содержит введенное число!";
    }
    return "нет, в массиве нету введенного числа!";
}

int inputNumber()
{
    int number;
    string text;

    while (true)
    {
        Console.Write("Введите число: ");
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}

