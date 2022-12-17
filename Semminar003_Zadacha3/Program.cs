// Напишите программу, которая будет принимать на вход два числа и выводить,
//является ли второе число кратным первому если число 2 не кратно числу 1,
//то программа выводит остаток от деления.
//34,5 -> не кратно, остаток 4
//16,4 -> кратно

Console.Clear();
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
int ost = number2%number1;
if (ost == 0)
{
    Console.WriteLine($"Число {number2} кратно числу {number}");
}
else
{
    Console.WriteLine($"Остаток {ost}");
}
