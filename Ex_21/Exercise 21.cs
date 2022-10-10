// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

Console.WriteLine("Введите координат X первой точки");
int Xa = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координат Y первой точки");
int Ya = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координат Z первой точки");
int Za = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координат X второй точки");
int Xb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координат Y второй точки");
int Yb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координат Z второй точки");
int Zb = int.Parse(Console.ReadLine()!);

double result = Math.Sqrt(Math.Pow(Xb-Xa, 2) + Math.Pow(Yb-Ya, 2) + Math.Pow(Zb-Za, 2));
Console.WriteLine(Math.Round(result,2));
