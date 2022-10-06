// Задание №2 "По заданному номеру дня недели вывести его название"

Console.WriteLine("Введите номер дня недели (от 1 до 7 включительно)");
int a = Convert.ToInt16(Console.ReadLine());
var b = new string [] {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

if (a < 8)
{
    if (a > 0)
    {
        var c = b [a-1];
        Console.WriteLine(c);
    }
    else
    {
        Console.WriteLine("Число должно быть от 1 до 7 включительно");
    }
}
else
{
Console.WriteLine("Число должно быть от 1 до 7 включительно");
}