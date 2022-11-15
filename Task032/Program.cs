// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// Например: [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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
int [] RemoutElement(int[]arr)
{
    int k = 0;
    for (k = 0; k < (arr.Length); k++)
    {
        arr[k] =arr[k] * (-1);
    }
    return arr;
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
int [] newArray = RemoutElement(myArray);
PrintArray(newArray);

