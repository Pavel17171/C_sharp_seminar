// E03. Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine() ?? "0");
int mult = 1;
for (int i = 1; i < num + 1; i++) mult *= i;

Console.WriteLine(mult);    //произведение всех чисел от 1 до N включительно, т.е. факториал