//Задание №3 "Задать номер четверти, показать диапазоны для возможных координат"

Console.WriteLine("Введите значение x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение y");
int y = Convert.ToInt32(Console.ReadLine());

if (x != 0 && y != 0)
    if (y > 0)
        if (x > 0)
            Console.WriteLine("I четверть (x > 0; y > 0)");
        else
            Console.WriteLine("II четверть (x < 0; y > 0)");
    else
        if (x < 0)
            Console.WriteLine("III четверть (x < 0; y < 0)");
        else
            Console.WriteLine("IV четверть (x > 0; y < 0)");
else
    if (x == 0 && y == 0)
    {
        Console.WriteLine("Точка пересечения осей x и y (x = 0; y = 0)");
    }
    else if (x == 0)
    {
        Console.WriteLine("Точка лежит на оси x (x = 0; y любое число, кроме 0)");
    }
    else if (y == 0)
    {
        Console.WriteLine("Точка лежит на оси y (x любое число, кроме 0; y = 0)");
    }