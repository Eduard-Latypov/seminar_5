// Решение в группах задач:
// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 



int[] GetArray(int size, int leftRange, int RightRange)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(leftRange, RightRange + 1);
    }
    foreach (var item in arr)
    {
        System.Console.Write(item + " ");
    }
    return arr;
}
int[] myArray = GetArray(10, -9, 9);
System.Console.WriteLine();
void ReverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }
    foreach (var item in arr)
    {
        System.Console.Write(item + " ");
    }
}
ReverseArray(myArray);

