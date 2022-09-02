/* Вторая задача. Программа, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве. */
Console.Clear();
Console.WriteLine("Прграмма принимает на вход координтаы трех точек и выводит расстояние между ними в 3D пространстве");
bool repeat = true;

while(repeat)
{
    Console.Write("Введите координаты первой точки А: ");
    Console.Write("Введите х: ");
    int xa = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите у: ");
    int ya = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите z: ");
    int za = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите координаты первой точки В: ");
    Console.Write("Введите х: ");
    int xb = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите у: ");
    int yb = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите z: ");
    int zb = Convert.ToInt32(Console.ReadLine());

    double distance = Math.Sqrt(Math.Pow((xb - xa),2) + Math.Pow((yb - ya),2) + Math.Pow((zb - za),2));
    Console.Write("Для продолжения нажмите 'ENTER'. Для выхода 'E', затем 'ENTER'");
    string? decision = Console.ReadLine();

    if (decision?.ToLower() == "e")
    {
        repeat = false;
    }
    Console.WriteLine(distance);
}