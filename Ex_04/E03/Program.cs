// E03. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

Console.WriteLine("Введите количество элементов в массиве");
int quantity = int.Parse(Console.ReadLine() ?? "0");
Random rand = new Random();
int[] array = new int[quantity];


Console.Write("Наш массив: ");
for (int i = 0; i < quantity; i++)
{
    array[i] = rand.Next(100, 1000);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();


int countEven = 0;                      //Счетчик чентых чисел
int countOdd = 0;                       //Счетчик нечетных чисел
for (int i = 0; i < quantity; i++)
{
    if (array[i] % 2 == 0)
        countEven++;
    else
        countOdd++;
}
Console.WriteLine($"В массиве {countEven} четных чисел");
Console.WriteLine($"В массиве {countOdd} нечетных чисел");