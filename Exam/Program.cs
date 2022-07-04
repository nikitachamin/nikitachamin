void printArray(string[] ArrayToPrint)
{
    Console.Write("[");
    for (var i = 0; i < ArrayToPrint.Length; i++)
    {
        if (!string.IsNullOrEmpty(ArrayToPrint[i]))
        {
            if (i < ArrayToPrint.Length - 1)
            {
                Console.Write($"{ArrayToPrint[i]} ");
            }
            else
            {
                Console.Write($"{ArrayToPrint[i]}");
            }
        }
    }
    Console.Write("]");
}

string[] changedArray(string[] ArrayToChange)
{
    string[] result = new string[ArrayToChange.Length];
    for (var i = 0; i < ArrayToChange.Length; i++)
    {
        if (ArrayToChange[i].Length < 4)
        {
            result[i] = new string(ArrayToChange[i]);
        }
    }
    return result;
}
string[] Array = new string[] { "Russia", "Denmark", "Kazan", ":-)" };
printArray(Array);
string[] ChangedArray = changedArray(Array);
Console.Write("---->");
printArray(ChangedArray);


