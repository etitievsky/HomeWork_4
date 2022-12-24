// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

void FillArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(100);
    }
}


int [] array = new int [8];
FillArray(array);
Console.Write($"[{String.Join(",",array)}]");
