// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


Console.Clear();
const int SIZE = 30;
const int LEFT_RANGE = -100;
const int RIGHT_RANGE = 100;
int[] myArray = GetArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
System.Console.WriteLine();
System.Console.WriteLine(FindNumber(myArray));



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

string FindNumber(int[] arr)
{
    int count = 0;
    foreach (var item in arr)
    {
        if (item > 10 && item < 100)
            count += 1;
    }
    return $"Количество чисел больше 10 и меньше 100:   {count}";
}


