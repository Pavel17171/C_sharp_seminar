// E04. Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine() ?? "0");
int cub = 1;
for (int i = 1; i < num + 1; i++) 
{
    cub = i*i*i;
    if (cub % 2 == 0) 
        Console.WriteLine(i+ " в кубе = " +cub);
}