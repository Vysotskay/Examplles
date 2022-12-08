// Дано число. Проверить кратно ли оно 7 и 23 -
// Делиться и на 7 и на 23 без остатка

Console.Clear();
Console.Write("Введите число");
int number = int.Parse(Console.ReadLine());

if(number % 7 == 0 & number % 23 == 0)
{
    Console.WriteLine($"Число {number} кратно 7 и 23");
}
else
{
    Console.WriteLine($"Число {number} кратно 7 и 23");
}
 