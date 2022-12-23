//Напишите программу, которая принимает на вход число N и выдает набор произведений чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int GetCompNums(int number)
{
    int comp = 1;
    while(number > 1)
    {
        comp = comp * number;
        number--;
        Console.WriteLine($"{comp}");
    }

    Console.Write();
    return comp;
}
