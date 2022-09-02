/* Первая задача. Программа, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом. */
Console.Clear();
Console.Write("Введите пятизначное число:");
string num = Console.ReadLine();
if ((num[0] == num[4]) && (num[1] == num[3]))
{
    Console.WriteLine("Является палиндроммом");
}
else
{
    Console.WriteLine("Не является палиндроммом");
}

/* Альтернативное решение */
Console.Write("Введите пятизначное число:");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num2 >= 10000 && num2 <= 99999)
{
    if((num2 / 10000 == num2 % 10) && (num2 % 10000 / 1000 == num2 % 100 / 10))
    {
        Console.WriteLine("Является палиндроммом");
    }
    else
    {
        Console.WriteLine("Не является палиндроммом");
    }
}