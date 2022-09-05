// Вторая задача. Программа, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
int SumOfNum(int a)
{
    int sum = 0;
    if(a > 0)
    {
        while (a > 0)
        {
            sum = sum + a % 10;
            a = a / 10;
        }
        return sum;
    }
    else if(a == 0)
    {
        return sum;
    }
    else
    {
        int b = 1;
        b = a * 2;
        a = a - b;
        while (a > 0)
        {
            sum = sum + a % 10;
            a = a / 10;
        }
        return sum;
    }
}
Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр введенного числа {num1} равна {SumOfNum(num1)}");