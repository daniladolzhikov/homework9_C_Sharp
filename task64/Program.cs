// Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string PrintNum(int num)
{
    if (num == 1) return "1";
  
    return num + "," + PrintNum(num - 1);
}

Console.Clear();
System.Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Натуральные числа в промежутке от {num} до 1: ");
System.Console.WriteLine(PrintNum(num));
