﻿Console.WriteLine("Введите элементы массива через запятую:");
string[] inputArray = EnterArray();

string[] resultArray = FilterArray(inputArray);

Console.WriteLine("Результат:");
PrintArray(inputArray, resultArray);

string[] EnterArray()
{
    string input = Console.ReadLine();
    return input.Split(',');
}

string[] FilterArray(string[] inputArray)
{
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            count++;
        }
    }

    string[] resultArray = new string[count];
    int j = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            resultArray[j] = inputArray[i];
            j++;
        }
    }

    return resultArray;
}

void PrintArray(string[] inputArray, string[] resultArray)
{
    Console.Write("[" + string.Join(", ", inputArray) + "] -> ");
    Console.WriteLine("[" + string.Join(", ", resultArray) + "]");
}