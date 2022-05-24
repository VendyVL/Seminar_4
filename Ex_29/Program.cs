// Напишите программу, которая задаёт массив целых чисел и выводит их на экран. Размер массива определяется пользователем.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.WriteLine("Ведите размер массива");
int num = Convert.ToInt32(Console.ReadLine());

int[] array1 = new int[num];

int[] PrintArray (int[]array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(0, 100);
        Console.Write(array[i]+" ");
    }
    return array;
}

PrintArray (array1);
