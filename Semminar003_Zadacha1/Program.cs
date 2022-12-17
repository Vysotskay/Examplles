// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// Создание объекта для генерации чисел
Random rnd = new Random();

// Получить случайное число ( в диапозоне от 10 до 99)
int value = rnd.Next(10, 99);

// Вывод числа в консоль
Console.WriteLine(value);

int des = value/10;
Console.WriteLine(des);
int ed = value%10;
Console.WriteLine(ed);
if (des >ed)
{
    Console.WriteLine($"наибольшее число {des}" );
}
else
{
    Console.WriteLine($"наибольшее число {ed}" );
}
