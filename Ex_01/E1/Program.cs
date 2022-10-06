//Задание №1 "По двум заданным числам проверять является ли первое квадратом второго"

Console.WriteLine("Введите первое число ");


int a = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Введите второе число ");

int b = Convert.ToInt32(Console.ReadLine());

if (a / b == b)
{
    Console.WriteLine("Первое число ЯВЛЯЕТСЯ квадратом второго числа");
}
else
{
    Console.WriteLine("Первое число НЕ ЯВЛЯЕТСЯ квадратом второго числа");
}
