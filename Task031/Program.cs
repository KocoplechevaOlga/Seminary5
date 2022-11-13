// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.

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
    for (j = 0; j < (arr.Length-1); j++)
    {
        Console.Write(arr[j] + ", ");
    }
    Console.Write(arr[j]);
}
int SumPlusElemMas(int[] arr)
{
    int k = 0;
    int summ = 0;
    for (k = 0; k < (arr.Length-1); k++)
        if (arr[k] > 0) summ = summ + arr[k];
    return summ;
}
int SumMinusElemMas(int[] arr)
{
    int k = 0;
    int summ = 0;
    for (k = 0; k < (arr.Length-1); k++)
        if (arr[k] < 0) summ = summ + arr[k];
    return summ;
}

Console.WriteLine("Введите размер массива:");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное ограничение массива:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное ограничение массива:");
int b = Convert.ToInt32(Console.ReadLine())+1;
int [] res = FillArray(length, a, b);
PrintArray(res);
Console.WriteLine(" ");
int sumPlus = SumPlusElemMas(res);
Console.WriteLine($"Сумма положительных чисел массива сщставляет {sumPlus}");
int sumMinus = SumMinusElemMas(res);
Console.WriteLine($"Сумма отрицательных чисел массива сщставляет {sumMinus}");
