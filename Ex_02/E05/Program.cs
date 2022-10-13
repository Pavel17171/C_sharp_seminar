//Задание №5 "Найти расстояние между точками в пространстве 2D/3D"

Console.WriteLine("Введите цифру 2 для работы с 2D пространством, \nлибо цифру 3 для работы с 3D пространством");
int ans = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine(ans);
int x1, x2;
int y1, y2;
int z1, z2;
if (ans ==2)
{
    Console.WriteLine("Введите x1 для первой точки");
    x1 = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("Введите y1 для первой точки");
    y1 = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("Введите x2 для второй точки");
    x2 = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("Введите y2 для второй точки"); 
    y2 = int.Parse(Console.ReadLine() ?? "0");   

    int x3 = Convert.ToInt32(Math.Pow((x1 - x2), 2));
    int y3 = Convert.ToInt32(Math.Pow((y1 - y2), 2));
    double length = Math.Round((Math.Sqrt(x3 + y3)), 2);

    Console.WriteLine(length);

}
else if (ans == 3)
{
    Console.WriteLine("Введите x1 для первой точки");
    x1 = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("Введите y1 для первой точки");
    y1 = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("Введите z1 для первой точки");
    z1 = int.Parse(Console.ReadLine() ?? "0");    
    Console.WriteLine("Введите x2 для второй точки");
    x2 = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("Введите y2 для второй точки"); 
    y2 = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("Введите z2 для первой точки");
    z2 = int.Parse(Console.ReadLine() ?? "0");

    int x3 = Convert.ToInt32(Math.Pow((x1 - x2), 2));
    int y3 = Convert.ToInt32(Math.Pow((y1 - y2), 2));
    int z3 = Convert.ToInt32(Math.Pow((z1 - z2), 2));    
    double length = Math.Round((Math.Sqrt(x3 + y3 + z3)), 2);

    Console.WriteLine(length);
}
else
{
    Console.WriteLine("Введеное число не соответствует условию");
}