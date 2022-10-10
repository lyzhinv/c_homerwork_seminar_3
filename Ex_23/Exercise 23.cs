// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число больше 0");
double number = int.Parse(Console.ReadLine()!);
int i = 1;

if (number <= 0)
{
    Console.WriteLine("Введено не верное число. Пожалуйста, повторите попытку");
}
else
{
    while (i < number)
    {
        Console.Write($"{Math.Pow(i, 3)}, ");
    i++;
    }
    Console.Write($"{Math.Pow(i, 3)}");
}