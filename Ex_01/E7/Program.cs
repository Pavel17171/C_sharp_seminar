// Задание №7 "Показать последнюю цифру трёхзначного числа"

Console.WriteLine("Введите целое трёхзначное число");

int num = Convert.ToInt32(Console.ReadLine());
int a = 1000;
int b = 99;
if (num < a && num > b)
{
   Console.WriteLine("Последняя цифра введенного числа: {0}", num % 10); 
}
else
{
    Console.WriteLine("Введеное число не соответствует условию");
}