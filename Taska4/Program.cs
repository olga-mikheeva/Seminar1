// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа. 456 -> 6 782 -> 2 918 -> 8
//для предпоследнего следует сначала поделить на 10, а после деление без остатка на 10

Console.WriteLine("Введите трехзначно число n");
int number = int.Parse(Console.ReadLine()!);
int firstDigit = number / 100 ; 
int secondDigit = (number / 10) % 10 ; 
int thirdDigit = number % 10 ; 

Console.WriteLine($"Первая цифра в числе {number} равна {firstDigit}"); 
Console.WriteLine($"Вторая цифра в числе {number} равна {secondDigit}");
Console.WriteLine($"Третья цифра в числе {number} равна {thirdDigit}");
