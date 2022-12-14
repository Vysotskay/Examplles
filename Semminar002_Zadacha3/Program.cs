// Программа проверяет пятизначное число на палиндром.
Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);
int [] array = new int[5];         // Создаем массив.
int index = 4;                    // Исследуем элементы массива с конца.
while(index >= 0)
{
    array[index] = number%10;    // Получаем последнюю цифру в массиве.
    number = number/10;         // Переходим к следующему числу.
    index--;                   // Переходим к следующему элементу массива.
}
if(array[0] == array[4] && array[1] == array[3]) //
{
    Console.WriteLine($"Число является палиндромом.");
}
else
{
    Console.WriteLine($"Число не является палиндромом.");
}