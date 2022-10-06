//Напишите программу, которая принимает на вход трёхзначное число и на выходе 
//показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
Console.Write("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine());
if (n >= 0 && n.ToString().Length != 3) { Console.WriteLine($"Число {n} не является трехзначным"); }
else if (n < 0 && n.ToString().Length != 4) { Console.WriteLine($"Число {n} не является трехзначным"); }
else
{
    int num2 = (n % 100) / 10;
    if (num2 >= 0) { Console.WriteLine("Вторая цифра заданного числа: " + num2); }
    else { Console.WriteLine("Вторая цифра заданного числа: " + -num2); }
}