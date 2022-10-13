// E01. Найти кубы чисел от 1 до N.

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine() ?? "0");
for (int count = 1; count <= num; count++)
    Console.WriteLine(count+ " в кубе = " +count*count*count);