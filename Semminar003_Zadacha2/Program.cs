// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
Random rnd = new Random();
int value = rnd.Next(100, 1000);
Console.WriteLine(value);
int R = value%10;
int R1 = value/100;
int result = R1*10 + R;
Console.WriteLine(result);
