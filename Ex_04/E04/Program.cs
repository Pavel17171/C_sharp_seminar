// E04. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int quantity = 123;               //Количесество элементов в одномерном массиве (по условию 123)
int[] array = new int[quantity + 1];


for (int i = 1; i <= quantity; i++)
    array[i] = i;


int minBorder = 10;                // Нижняя граница отрезка (по условию 10)
int maxBorder = 99;                // Верхняя граница отрезка (по условию 99 включительно)
int count = 0;                     // Счетчик элементов массива из указанного отрезка
for (int i = 0; i < quantity; i++)
{
    if (array[i] >= minBorder && array[i] <= maxBorder)
        count++;
}
Console.WriteLine($"В нашем массиве {count} элементов, принадлежащих отрезку [{minBorder}:{maxBorder}].");