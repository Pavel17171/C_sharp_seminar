// E05. Найти сумму чисел одномерного массива стоящих на нечетной позиции

Console.WriteLine("Введите количество элементов одномерного массива");
int quantity = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[quantity];

Console.Write("Наш массив: ");
for (int i = 1; i <= quantity; i++)
{    
    array[i-1] = i;
    Console.Write($"{array[i-1]} ");
}

Console.WriteLine();

int sumNumdersOnOddIndex = 0;            // Cумма чисел массива, стоящих на нечетной позиции
for (int i = 0; i < quantity; i++)
{
    if (i % 2 != 0)
        sumNumdersOnOddIndex += array[i];
}
Console.WriteLine($"Cумма чисел массива, стоящих на нечетной позиции: {sumNumdersOnOddIndex}");

