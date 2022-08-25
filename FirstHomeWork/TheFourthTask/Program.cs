// Четвертая задача на вывод четных чисел в ряде от 1 до N.
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = 1;
int count = 1;

while(count <= num)
{
    if(num1 % 2 == 0)
    {
        Console.WriteLine(count);
        Console.WriteLine(" ");
        count = count + 1;
        num1 = num1 + 1;
    }
    else
    {
        count = count + 1;
        num1 = num1 + 1;
    }
}
