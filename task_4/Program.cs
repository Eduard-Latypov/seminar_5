// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


Console.Clear();
const int SIZE = 9;
const int LEFT_RANGE = -5;
const int RIGHT_RANGE = 5;
int[] myArray = GetArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
System.Console.WriteLine();
printArray(GetSum(myArray));









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


int[] GetSum(int[] arr)
{
    int[] myArray = new int[(arr.Length / 2) + (arr.Length % 2)];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        myArray[i] = arr[i] * arr[(arr.Length - 1) - i];
    }
    if (arr.Length % 2 != 0)
        myArray[myArray.Length - 1] = arr[arr.Length / 2];
    return myArray;
}

void printArray(int[] arr)
{
    System.Console.WriteLine($"[{String.Join(", ", arr)}]");
}

