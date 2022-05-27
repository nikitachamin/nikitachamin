int[] getRandomArray(int length, int deviation)
{
    int[] result = new int[length];
    for (var i = 0; i < length; i++)
    {
        result[i] = new Random().Next(100, deviation + 1);
    }
    return result;
}

void printArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (var i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }

    }
    Console.Write("]");
}

int FindANumber(int[] Array)
{
    int result = 0;
    for (var i = 0; i < Array.Length; i++)
    {
        if (Array[i]%2 == 0)
        {
            result++;
        }  
    }
     return result;
}
int[] randomArray = getRandomArray(100,999);
printArray(randomArray);
int result = FindANumber(randomArray);
Console.WriteLine($"{result}");
