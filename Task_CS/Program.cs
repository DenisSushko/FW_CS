// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
//либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] cutSymbols(string[] str)
{
    string[] result = new string[str.Length];
    int j = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length < 4)
        {
            result[j] = str[i];
            j++;
        }
    }
    Array.Resize<string>(ref result, j);
    return result;
}
void PrintArray(string[] arr)
{
    string str;

    if (arr.Length == 0)
    {
        str = "[]";
    }
    else
    {
        str = "[";
    }
    Console.WriteLine("Полученный массив: ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1)
        {
            str = str + arr[i] + "]";
        }
        else
            str = str + arr[i] + ", ";
    }
    Console.WriteLine(str);
}
string[] str1 = { "Hello", "2", "world", ":-)" };
string[] str2 = { "1234", "1567", "-2", "computer science" };
string[] str3 = { "Russia", "Denmark", "Kazan" };
string[] strCut1 = cutSymbols(str1);
string[] strCut2 = cutSymbols(str2);
string[] strCut3 = cutSymbols(str3);
PrintArray(strCut1);
PrintArray(strCut2);
PrintArray(strCut3);