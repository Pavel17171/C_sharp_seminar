// E07. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

//Создаем массив из вещественных чисел
Console.WriteLine("Введите количество элементов массива");
int quantity = int.Parse(Console.ReadLine() ?? "0");
decimal[] array = new decimal[quantity];
Random rand = new Random();

decimal elem;                                   // Значение от 0 до 1
int elem1;                                      // Целое значение в заданных границах
int minBorder = -10;                            // Нижний предел рандома
int maxBorder = 10;                             // Верхний предел рандома
Console.Write("Наш массив: ");
for (int i = 0; i < quantity; i++)
{
    elem = (decimal)rand.NextDouble();          // Рандом дробной части числа
    elem = Math.Round(elem, 2);                 // Округление до 2-х знаков после запятов
    elem1 = rand.Next(minBorder, maxBorder);    // Рандом целой части числа в заданных границах
    array[i] = elem1 + elem;                    // Добавление элементов рандомов в массив
    Console.Write($"{array[i]} ");
}

Console.WriteLine();

// Выполняем задание
decimal minNum = array[0];
decimal maxNum = array[0];
for (int i = 0; i < quantity; i++)
{
    if (array[i] < minNum)
        minNum = array[i];
    if (array[i] > maxNum)
        maxNum = array[i];
}
decimal dif = maxNum - minNum;
Console.WriteLine($"Минимальный элемент массива: {minNum}");
Console.WriteLine($"Максимальный элемент массива: {maxNum}");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {dif}");