// Первая задача. Введите с клавиатуры кол-во чисел и посчитайте, какие из них будут больше 0.
Console.Clear();

void FillArray(int[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        int random = new Random().Next(-99, 100);
        a[i] = random;
        Console.Write($"{a[i]} ");
    }
    Console.WriteLine();
    int count = 0;
    for(int i = 0; i < a.Length; i++)
    {
        if(a[i] > 0) count++;
        else count +=0;
    }
    if(count > 0) Console.WriteLine($"У вас получилось {count} число/числа/чисел, который(-ые) больше 0.");
    else Console.WriteLine($"У вас нет чисел больше 0.");
}
Console.WriteLine("Сколько у вас будет чисел?");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = new int [len];
FillArray(array);