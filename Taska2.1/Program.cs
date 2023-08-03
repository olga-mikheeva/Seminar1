// 
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
string[] days = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
Console.WriteLine(days[number -1]);