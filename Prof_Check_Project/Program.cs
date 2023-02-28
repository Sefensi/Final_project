/*Задача:Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться  коллекциями, лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]*/

//инициализируем массив

string[] array = {"hello", "2", "world new", ":-)"};

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }

    Console.Write("]");
    Console.WriteLine();
}

void GetThreeSymbolsArr(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            Console.Write($"{arr[i]}, ");
        }
    }

    Console.Write("]");
}

PrintArray(array);
GetThreeSymbolsArr(array);