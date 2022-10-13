//Задание №4 "Программа проверяет пятизначное число на палиндромом"

Console.WriteLine("Введите целое число");
int num = int.Parse(Console.ReadLine() ?? "0");
int num1 = num;
int num2 = num;
int count = 1;
bool answer = true;
while (num >=10)
{
    num /= 10;
    count++;
}
while (count > 1)
{
    if (num1 / Convert.ToInt32(Math.Pow(10, count - 1)) == num2 % 10)
    {
        int sqr = Convert.ToInt32(Math.Pow(10, count - 1));
        num1 = num1 % sqr;
        num2 /= 10;
        answer = true;
    }
    else
    {
        answer = false;
        break;
    }
    count--;
}
if (answer == true)
    Console.WriteLine("Введеное число является палиндромом");
else
    Console.WriteLine("Введеное число НЕ является палиндромом");