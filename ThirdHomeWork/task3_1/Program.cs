/* Первая задача. Программа, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом. */
Console.Clear();
Console.Write("Введите пятизначное число:");
int inputNum = Convert.ToInt32(Console.ReadLine());
string num = Convert.ToString(inputNum);

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
int nummber = Convert.ToInt32(Console.ReadLine());

if(nummber >= 10000 && nummber <= 99999)
{
    if((nummber / 10000 == nummber % 10) && (nummber % 10000 / 1000 == nummber % 100 / 10))
    {
        Console.WriteLine("Является палиндроммом");
    }
    else
    {
        Console.WriteLine("Не является палиндроммом");
    }
}