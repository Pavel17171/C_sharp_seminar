// Задание №11 "Выяснить, кратно ли число заданному, если нет, вывести остаток."

Console.WriteLine("Введите первое целое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    if (num1 % num2 == 0)
    {
        Console.WriteLine("Первое число кратно второму");
    }
    else
    {
        Console.WriteLine("Остаток от деления первого числа на второе: {0}", num1 % num2);
    }
}
else
{
    if (num2 % num1 == 0)
    {
        Console.WriteLine("Второе число кратно первому");
    }
    else
    {
        Console.WriteLine("Остаток от деления второго числа на первое: {0}", num2 % num1);
    }
}
