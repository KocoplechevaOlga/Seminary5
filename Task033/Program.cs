// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//Например: 4; массив [6, 7, 19, 345, 3] -> нет; 3; массив [6, 7, 19, 345, 3] -> да 1n

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
bool FindDig(int [] arr, int n)
{
    bool b = false;
    for (int i = 0; i < (arr.Length); i++)
    {
        if (arr[i] == n) 
        {
            b = true;
            break;
        }
    }    
    return b;
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
Console.WriteLine("Введите искомое число:");
int l = Convert.ToInt32(Console.ReadLine());

bool find = FindDig (myArray, l);
Console.WriteLine (FindDig (myArray, l) ? " ->  Да" : " ->  Нет");
