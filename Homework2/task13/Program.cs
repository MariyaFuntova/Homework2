int number = new Random().Next(1,1000);
Console.WriteLine();
if  ( (number / 100) > 0)
{
    Console.WriteLine($"Третьей цифрой числа {number} является {(number / 100) % 10}");
    }
else Console.WriteLine($"У числа {number} нет третьей цифры");
