// Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
//расстояние d=Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2)+Math.Pow((z1-z2),2)

Console.Clear();
Console.WriteLine("Введите координату x1: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y1: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату z1: ");
int z1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Х2: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату y2: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату z2: ");
int z2 = int.Parse(Console.ReadLine()!);

double dist = Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2)+Math.Pow((z1-z2),2));
Console.WriteLine($"Расстояние между двумя точками А({x1},{y1},{z1}) и B({x2},{y2},{z2}) равно {dist:f2}");