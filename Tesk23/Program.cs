// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 4, 9. 
//5 -> 1, 8, 27, 64, 125

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int num = ReadInt("Введите целое положительное число");

for(int i=1; i< num; i++)
{
Console.WriteLine($"  {Math.Pow(i,3)}");
}
