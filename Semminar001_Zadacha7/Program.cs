// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int EndOfNumber = number%10;
Console.Write(EndOfNumber);
if ((number<100)||(number>999))
{
    Console.WriteLine("Введите трехзначное число: ");
}

