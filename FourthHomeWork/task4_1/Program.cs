Console.Clear();

void Degree(int a, int b)
{
    int res = 1;
    for(int count = 0; count < b; count++)
    {
        res = res * a;
    }
    Console.WriteLine(res);
}

Console.WriteLine("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В: ");
int B = Convert.ToInt32(Console.ReadLine());
Degree(A, B);