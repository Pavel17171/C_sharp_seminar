// Задание №5 "Показать числа от -N до N"

Console.WriteLine("Введите целое число");

int number = Convert.ToInt32(Console.ReadLine());

if (number >= 0)
{
    int num1 = number * (-1) - 1;
    while (num1 != number)
    {
        num1++;
        Console.WriteLine(num1);
    }
}
else if (number < 0)
{
    int num1 = number * (-1) + 1;
    while (num1 != number)
    {
        num1--;
        Console.WriteLine(num1);
    }
}