//Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int l = n.ToString().Length;
if (n >= 0 && l < 3) { Console.WriteLine("В заданном числе отсутствует третья цифра"); }
else if (n < 0 && l < 4) { Console.WriteLine("В заданном числе отсутствует третья цифра"); }
else
{
    while (n > 999 || n < -999) { n = n / 10; }
    int num3 = n % 10;
    if (n >= 0) { Console.WriteLine("Третья цифра заданного числа: " + num3); }
    else { Console.WriteLine("Третья цифра заданного числа: " + -num3); }
}