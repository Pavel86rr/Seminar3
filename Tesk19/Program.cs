// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// 
 Console.WriteLine("Введите пятизначное число");
 string? str = Console.ReadLine();
 Console.ReadLine();
  int num1 = Convert.ToInt32(Convert.ToString(str[0]));
      Console.WriteLine(num1);
  int num5 = Convert.ToInt32(Convert.ToString(str[4]));
      Console.WriteLine(num5);
  int num2 = Convert.ToInt32(Convert.ToString(str[1]));
      Console.WriteLine(num2);
  int num4 = Convert.ToInt32(Convert.ToString(str[3]));
      Console.WriteLine(num4);

     if(num1==num5 || num2==num4)
     {
       Console.WriteLine("Число является палиндромом");
     }
     else 
     {
       Console.WriteLine("Число  не является палиндромом");
     }



//}
 //else
//{
//Console.WriteLine("Число не сответствует заданным параметрам");
//}