// Задание №9 "Дано число из отрезка [10, 99]. Показать наибольшую цифру числа"

Console.WriteLine("Введите целое число от 10 до 99 включительно");

int num = Convert.ToInt32(Console.ReadLine());
int a = 100;
int b = 9;
if (num < a && num > b)
{
   int x = num / 10;
   int y = num % 10;
   if (x > y)
   {
    Console.WriteLine("Наибольшая цифра введенного числа: {0}", x);
   }
   else
   {
    Console.WriteLine("Наибольшая цифра введенного числа: {0}", y);
   }
}
else
{
    Console.WriteLine("Введеное число не соответствует условию");
}