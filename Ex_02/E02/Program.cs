//Задание №2 "По двум заданным числам проверять является ли одно квадратом другого"

Console.WriteLine("Введите первое целое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int b = Convert.ToInt32(Console.ReadLine());

if (a >= b)
    if (b * b == a)
        Console.WriteLine("Первое число является квадратом второго числа");
    else
        Console.WriteLine("Ниодно число НЕ является квадратом другого числа");
else
    if (a * a == b)
        Console.WriteLine("Второе число является квадратом первого числа");
    else
        Console.WriteLine("Ниодно число НЕ является квадратом другого числа");