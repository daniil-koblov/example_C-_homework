// Напишите программу, которая принимает на вход цифру,  
// обозначающую день недели, и проверяет, 
// является-ли этот день выходным.
Console.WriteLine("Введите номер дня недели(от 1 до 7): ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0 & num < 8)
{
    if(num > 5)
    {
       Console.WriteLine("Это выходной"); 
    }
    else
    {
       Console.WriteLine("Это будничный день");
    }
}
else
{
    Console.WriteLine("ОШИБКА! Надо вводить цифры от 1 до 7:");
}
