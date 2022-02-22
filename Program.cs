/* **Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

**Примеры**:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> [] */

string text = "Широка страна моя родная, "
            + "Много в ней лесов, полей и рек! "
            + "Я другой такой страны не знаю, "
            + "Где так вольно дышит человек.";
Console.WriteLine("Начальная строка:");
Console.WriteLine(text);
Console.WriteLine();
text = text.Replace(",", String.Empty);
text = text.Replace("!", String.Empty);
text = text.Replace(".", String.Empty);
Console.WriteLine("Строка без знаков препинания:");
Console.WriteLine(text);
Console.WriteLine();
string[] words = text.Split(" ");
string[] words3 = new string[words.Length];

void FillArray(string[] strArray, string[] strArray2) 
{
    int k = 0; //счетчик слов нужной длины
    for (int i = 0; i < strArray.Length; i++)
    {
        if (strArray[i].Length<4)
        {
            strArray2[k] = strArray[i];
            k++;  
        }  
    }
}

void PrintArray(string[] strArray2 )
{
    for (int j = 0; j < strArray2.Length; j++)
    {
        Console.Write($"{strArray2[j]}"+' ');
    }
}

FillArray(words, words3);
Console.WriteLine("Окончательный вывод согласно условию задачи:");
PrintArray(words3);
