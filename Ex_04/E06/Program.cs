// E06. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

// Создаем одномерный массив
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

// Выполняем задание
Console.Write("Произведение пар чисел: ");
int mult;
for (int i = 0; i < quantity / 2; i++)         // Если в массиве нечетное количество элементов, то у среднего нет пары, поэтому не выводим.
{
    mult = array[i] * array[quantity - i - 1];
    Console.Write($"{mult} ");
}