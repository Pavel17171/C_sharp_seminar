// Задание №3 "Найти максимальное из трех чисел"

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());

int max = a;

Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

if (b > max)
{
    max = b;
}

Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine()); 

if (c > max)
{
    max = c;
}

Console.WriteLine("Максимальное число = {0}", max);