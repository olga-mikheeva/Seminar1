// //Напишите программу, которая на вход принимает два //числа и проверяет, является ли первое число //квадратом второго. 
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет

Console.Write("Введите первое целое число: "); 
int iNumberA = int.Parse(Console.ReadLine()!); 
Console.Write("Введите второе целое число: "); 
int iNumberB = int.Parse(Console.ReadLine()!); 
if (iNumberA / iNumberB == iNumberB)
 {
 Console.WriteLine($"Условие выполнено: {iNumberA} является квадратом {iNumberB}"); 
} 
else 
{ 
Console.WriteLine($"Условие не выполнено: {iNumberA} не является квадратом {iNumberB}"); 
}

