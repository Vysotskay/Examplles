// Напишите прорамму, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

//Console.Write("Введите чсло: ");
//int num = int.Parse(Console.ReadLine());
//int num2 = int.Parse(Console.ReadLine());
//int sum1 = GetSumNums(num);
//int sum2 = GetSumNums(num2);
//Console.WriteLine(sum1);
//Console.WriteLine(sum2);

//int GetSumNums(int number)
//{
    //int sum = 0;
    //while(number > 0)
    //{
        //sum += number;
        //number--;
         //Console.Write($"{sum} ");
    //}
    //Console.WriteLine();
    //return sum;
//}




Console.Write("Введите чсло: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма цифр = {GetSumNums(num)} ");

int GetSumNums(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum += number;
        number--;
         Console.Write($"{sum} ");
    }
    Console.WriteLine();
    return sum;
}