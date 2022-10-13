// E02. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

Random rand = new Random();
int quantity = 12;                   // Количество элементов в массиве (по условию 12)
int minBorder = -10;                // Нижняя граница рандома (по условию 0)
int maxBorder = 10;               // Верхняя граница рандома (по условию 9 включительно)
int[] array = new int[quantity];


Console.Write("Наш массив: ");
for (int i = 0; i < quantity; i++)
{   
    array[i] = rand.Next(minBorder, maxBorder); 
    Console.Write($"{array[i]} ");
}
Console.WriteLine();


int sumPositive = 0;              // Сумма положительных чисел в массиве
int sumNegative = 0;              // Сумма отрицательных чисел в массиве (по модулю)
for (int i = 0; i < quantity; i++)
    if (array[i] >= 0)
        sumPositive += array[i];
    else 
        sumNegative += array[i];
Console.WriteLine($"Сумма положительных чисел равна = {sumPositive}");
Console.WriteLine($"Сумма отрицательных чисел равна = {sumNegative}");