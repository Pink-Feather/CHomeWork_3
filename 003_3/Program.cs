// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int count = 1;
Console.Write("Таблица кубов: ");
while (count <= num)
{
    Console.Write($"{Math.Pow(count,3)} ");
    count++;
}