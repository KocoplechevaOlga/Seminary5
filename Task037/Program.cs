// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
//и т.д. Результат запишите в новом массиве

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
int [] FillArrayMult(int [] arr)
{
    int size = arr.Length/2;
    if (arr.Length % 2 == 1) size = size + 1;
    int [] newArray = new int [size];
        for (int i = 0; i < arr.Length/2; i++)
        {
            newArray[i] = arr[i]*arr[arr.Length-1-i];
        }
        if (arr.Length % 2 == 1) newArray[newArray.Length-1] = arr[arr.Length/2];
    return newArray;
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
int [] arrayMult = FillArrayMult(myArray);
PrintArray(arrayMult);