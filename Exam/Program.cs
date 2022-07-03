void printArray(string[] ArrayToPrint)
{
   Console.Write("[");
    for (var i = 0; i < ArrayToPrint.Length; i++)
    {
        Console.Write(ArrayToPrint[i]);
        if (i != ArrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

string[] changedArray(string[] ArrayToChange)
{
    string [] result = new string [ArrayToChange.Length];
    for (var i = 0; i < ArrayToChange.Length; i++)
    {
       if (ArrayToChange[i].Length < 4) 
       {
         result[i]= new string (ArrayToChange[i]); 
       }
    }
  return result;
}
string []Array = new string[] {"hello","2","world"};
printArray(Array);
string [] ChangedArray = changedArray(Array);
printArray(ChangedArray);


