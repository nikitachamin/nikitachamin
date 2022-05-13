int rundomNumber = new Random().Next(10,100000);

Console.WriteLine($"Изначальное число {rundomNumber}");

if (rundomNumber > 100  & rundomNumber < 1000)
{
  int third = rundomNumber % 10;
  Console.WriteLine($"Третья цифра - {third}");
}

if (rundomNumber > 1000 & rundomNumber < 10000)
{
   int third = rundomNumber % 100 / 10;
  Console.WriteLine($"Третья цифра - {third}");
 
}
if (rundomNumber > 10000 & rundomNumber < 100000)
{
  int third = rundomNumber / 100 % 10;
  Console.WriteLine($"Третья цифра - {third}");
}
if ( rundomNumber < 100)
{
    Console.WriteLine("третьего числа нет");
}