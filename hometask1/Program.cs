int rundomNumber = new Random().Next(100,1000);

Console.WriteLine($"Изначальное число {rundomNumber}");

int numberOne = rundomNumber / 10 % 10;


Console.WriteLine($"{numberOne}");
