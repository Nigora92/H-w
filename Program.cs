// Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.


// int Prompt(string message)
// {
//   Console.Write(message);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// int NaturalNumber(int n, int m)
// {
//   if (n == m) return n;
//   else Console.Write($"{NaturalNumber(n, m + 1)}, ");
//   return m;
// }

// int n = Prompt("Input N: ");
// if (n < 1)
// {
//   Console.WriteLine("Введите положительное число!");
//   return;
// }
// Console.WriteLine(NaturalNumber(n, 1));


 //Задача 2: Напишите программу вычисления функции Аккермана с помощью 
 //рекурсии. Даны два неотрицательных числа m и n.

//  int Prompt(string message)
// {
//   Console.Write(message);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// int Akkerman(int m, int n)
// {
//   if (m == 0) return n + 1;
//   if (m > 0 && n == 0) return Akkerman(m - 1, 1);
//   else return Akkerman(m - 1, Akkerman(m, n - 1));
// }

// int m = Prompt("Input M: ");
// int n = Prompt("Input N: ");

// Console.WriteLine($"A({m},{n}) = {Akkerman(m, n)}");

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с 
// конца. Использовать рекурсию, не использовать циклы.


// namespace New_Project 
// {  
//   public static class Program  
//   { 
//     public static void print(int [] A, int n) 
//     { 
//       if (n > 0) 
//       { 
//       	Console.Write(A[n] + " "); 
//       	print(A, n - 1); 
//       } 
//       else Console.WriteLine(A[0]); 
//     } 
//     public static void Main()   
//     { 
//       int [] num = {1, 2, 5, 0, 10, 34}; 
//       print(num, num.Length - 1); 
//     }  
//   }   
// }