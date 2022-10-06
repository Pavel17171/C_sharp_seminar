// Задание №8 "Показать вторую цифру трёхзначного числа"

Console.WriteLine("Введите целое трёхзначное число");

int num = Convert.ToInt32(Console.ReadLine());
int a = 1000;
int b = 99;
if (num < a && num > b)
{
   Console.WriteLine("Вторая цифра введенного числа: {0}", (num % 100 / 10)); 
}
else
{
    Console.WriteLine("Введеное число не соответствует условию");
}