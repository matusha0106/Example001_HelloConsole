﻿void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index = index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0; 
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
        //return не используется в коде, если есть void - метод, который ничего не возвращает
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
        }
        index ++;
    }
    return position;
}

int [] array = new int [10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);