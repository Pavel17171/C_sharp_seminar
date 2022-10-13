//Задание №1 "Дано число обозначающее день недели. Выяснить является номер дня недели выходным"

Console.WriteLine("Введите номер дня недели (целое число от 1 до 7 включительно)");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0 && num < 8)
    if (num == 6 || num == 7)
        Console.WriteLine("Ура!!! Выходной!!!");
    else
        Console.WriteLine("Будний день");
else
    Console.WriteLine("Введите целое число от 1 до 7 включительно");