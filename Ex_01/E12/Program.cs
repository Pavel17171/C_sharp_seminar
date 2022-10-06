// Задание №12 "Найти третью цифру числа или сообщить, что её нет"

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99)
{
    while (num >= 1000)
    {
    num /= 10;
    }
    Console.WriteLine("Третья цифра числа: {0}", (num % 10));
}
else
{
    Console.WriteLine("Введеное число не имеет третьей цифры");
}