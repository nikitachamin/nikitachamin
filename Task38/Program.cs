int[] getRandomArray(int length, int deviation)
{
    int[] result = new int[length];
    for (var i = 0; i < length; i++)
    {
        result[i] = new Random().Next(0, deviation + 1);
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

int FindMin(int[] Array)
{
    int min = Array[0];
    for (var i = 0; i < Array.Length; i++)
    {
        if (Array[i] < min)
        {
            min = Array[i];
        }  
    }
     return min;
}
int FindMax(int[] Array)
{
    int max = Array[0];
    for (var i = 0; i < Array.Length; i++)
    {
        if (Array[i] > max)
        {
            max = Array[i];
        }  
    }
     return max;
}
int[] randomArray = getRandomArray(10,20);
printArray(randomArray);
int min = FindMin(randomArray);
Console.WriteLine($"минимальное число {min}");
int max = FindMax(randomArray);
Console.WriteLine($"максимальное число {max}");
int result = max - min;
Console.WriteLine($"Разница между максимальным и минимальным числом - {result}");


