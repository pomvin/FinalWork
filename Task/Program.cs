//Задача: Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. 

Console.Clear();

string[] arr1 = new string[12] {
                                "Life","П", "9999",
                                "Р", "5000", "И",
                                "Fill", "В", "Е",
                                "Folse", "Т", ":)"};

string[][] matrix = new string[][] {arr1};

for (int i = 0; i < matrix.Length; i++)
{
    Console.Write("[");
    PrintArray(matrix[i]);
    Console.Write("]");

    Console.Write(" -> ");

    Console.Write("[");
    int lengthArray = ArrayLength(DefinedArrayLength(matrix[i]));
    PrintArray(ResultsArray(DefinedArrayLength(matrix[i]), lengthArray));
    Console.WriteLine("]");
}

string[] DefinedArrayLength(string[] arr)
{
    string[] res = new string[arr.Length];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
            {
                res[j] = arr[i];
                j++;
            }
    }
    return res;
}

int ArrayLength(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != null) count++;
    }
    return count;
}

string[] ResultsArray(string[] arr, int length)
{
    string[] res = new string[length];
    for (int i = 0; i < length; i++) 
    {
        res[i] = arr[i];
    }
    return res;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
       Console.Write($"{arr[i]}");
        if (i != arr.Length - 1) Console.Write(", ");
    }
}
