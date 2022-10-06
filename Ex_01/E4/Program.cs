// Задание №4 "Выяснить является ли число чётным"

Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Введеное число ЯВЛЯЕТСЯ чётным");
}
else
{
    Console.WriteLine("Введеное число НЕ ЯВЛЯЕТСЯ чётным");
}