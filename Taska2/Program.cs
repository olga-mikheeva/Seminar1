// Напишите программу, которая будет выдавать название дня недели по заданному номеру. 3 -> Среда 5 -> Пятница
Console.Write("Введите целое число: "); 
int numberA = int.Parse(Console.ReadLine()!); 
if (numberA == 1) 
{ 
Console.WriteLine("Понедельник! "); 
} 
else if (numberA == 2) 
{ 
Console.WriteLine("Вторник! "); 
} 
else if (numberA == 3) 
{ 
Console.WriteLine("Среда! "); 
} 
else if (numberA == 4) 
{ 
Console.WriteLine("Четверг! "); 
} 
else if (numberA == 5) 
{ 
Console.WriteLine("Пятница!!! "); 
} 
else if (numberA == 6) 
{ 
Console.WriteLine("Суббота!!! "); 
} 
else if (numberA == 7) 
{ 
Console.WriteLine("Воскресенье:( "); 
} 
else 
{ 
Console.WriteLine("Такого дня не существует :( "); 
}

