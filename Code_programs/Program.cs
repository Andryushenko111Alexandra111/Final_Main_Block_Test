/*
Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, 
либо равна 3 символам. Первоначальный массив можно ввести 
с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
*/

Console.Clear();

﻿string[] arrayStr = new string[6] {"Мир", "Труд", "Май", "Любовь", "Лом", "Лоб"};

int GetCount(string[] arrayStr)
{
    int count = 0;
    for (int i = 0; i < arrayStr.Length; i++)
    {
    if(arrayStr[i].Length <= 3)
        {
        count++;
        }
    }
    return count;
}
string[] GetArrayResult(string[] arrayStr, int count)
{
    var arrayResult = new string [count];
    int j = 0;
    for (int i = 0; i < arrayStr.Length; i++)
    {
    if(arrayStr[i].Length <= 3)
        {
        arrayResult[j] = arrayStr[i];
        j++;
        }
    }
    return arrayResult;
}
void PrintArray(string[] array)
{
        Console.WriteLine(string.Join(", ", array));
}
var count = GetCount (arrayStr);
var arrayResult = GetArrayResult(arrayStr, count);
PrintArray(arrayStr);
PrintArray(arrayResult);


