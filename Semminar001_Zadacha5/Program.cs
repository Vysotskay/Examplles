// Введите число N и выведите все числа от -N до N
Console.Clear();
Console.WriteLine("Введите целое число");
int number = int.Parse(Console.ReadLine());
int count = number * -1;
while(count <= number)
{
    Console.Write($"{count}, ");
    count++;
}
