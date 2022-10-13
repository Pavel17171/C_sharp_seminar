// E01. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

Random rand = new Random();
for (int i = 0; i < 8; i++)
    {
    int arr = rand.Next(2);
    Console.Write($"{arr} ");
    }