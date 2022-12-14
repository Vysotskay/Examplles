// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем Х не равно 0 и У не равно 0
Console.Clear();
Console.WriteLine("Введите х");
int x = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите у");
int y = int.Parse(Console.ReadLine() ?? "0");
if(x>0)

    if(y>0)

        Console.WriteLine("Первая четверть");

    else

    Console.WriteLine("Четвертая четверть");

else
    if(y>0)

        Console.WriteLine("Вторая четверть");

    else
        Console.WriteLine("Третья четверть");
                    
