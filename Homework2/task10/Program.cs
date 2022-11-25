int number = new Random().Next(100, 999);
Console.WriteLine($"Второй цифрой числа {number} является { (number / 10) % 10 }");


