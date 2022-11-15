// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 

int[] FillArray(int l, int min, int max)
{
    int[] array = new int[l];
    Random rnd  = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    } 
    return array;
}
void PrintArray(int[] arr)
{
    int j = 0;
    Console.Write("[");
    for (j = 0; j < (arr.Length-1); j++)
    {
        Console.Write(arr[j] + ", ");
    }
    Console.Write(arr[j]);
    Console.Write("]");
}
int CountDigFor(int [] arr, int min, int max)
{
    int count = 0;
    for (int i = 0; i < (arr.Length); i++)
    {
        if (arr[i] >= min && arr[i] <= max) 
        {
            count ++;
        }
    }    
    return count;
}

Console.WriteLine("Введите размер массива:");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное ограничение массива:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное ограничение массива:");
int b = Convert.ToInt32(Console.ReadLine())+1;
int [] myArray = FillArray(length, a, b);
PrintArray(myArray);
Console.WriteLine(" ");
Console.WriteLine("Введите минимальное значение отрезка:");
int xmin = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение отрезка:");
int xmax = Convert.ToInt32(Console.ReadLine());
int res = CountDigFor(myArray, xmin, xmax);
Console.WriteLine($"В заданном массиме содержится {res} из отрезка от {xmin} до {xmax}");