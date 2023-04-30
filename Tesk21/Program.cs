
//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
int[] coordsA = new int[3];

Console.WriteLine("Введите координату  X точки А");
coordsA[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату  Y точки А");
coordsA[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату  Z точки А");
coordsA[2] = Convert.ToInt32(Console.ReadLine());

int[] coordsB = new int[3];

Console.WriteLine("Введите координату  X точки B");
coordsB[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату  Y точки B");
coordsB[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату  Z точки B");
coordsB[2] = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(coordsA[0]-coordsB[0], 2) + Math.Pow(coordsA[1]-coordsB[1], 2) + Math.Pow(coordsA[2]-coordsB[2], 2));

Console.WriteLine(Math.Round(distance, 3));
