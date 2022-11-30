//Напишите программу, которая на вход принимает число и выдает ее квадрат (число умноженное на само себя).
Console.Clear();
Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());
//Находим квадрат числа
int sqr = number * number;
Console.WriteLine($"Квадрат числа {number} равен {sqr}");