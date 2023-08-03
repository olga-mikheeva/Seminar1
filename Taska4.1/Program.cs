// вариант задачи №4
Console.WriteLine("Введите четырехзначное число n");
int number = int.Parse(Console.ReadLine()!);
int firstDigit = number / 1000 ; 
int secondDigit = (number / 100) % 10 ; 
int thirdDigit = (number / 10) % 10 ;  
int fourDigit = number % 10 ;

Console.WriteLine($"Первая цифра в числе {number} равна {firstDigit}"); 
Console.WriteLine($"Вторая цифра в числе {number} равна {secondDigit}");
Console.WriteLine($"Третья цифра в числе {number} равна {thirdDigit}");
Console.WriteLine($"Четвертая цифра в числе {number} равна {fourDigit}");
