// Задание №6 "Показать четные числа от 1 до N"

Console.WriteLine("Введите целое число больше 0");
int num = Convert.ToInt32(Console.ReadLine());
int x = 0;
while(x < num)
{
    x += 2;
    if (x <= num)
    {
    Console.WriteLine(x);
    }
}