// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. (можно решить через строку, а можно математически)

Console.WriteLine("Введите пятизнаное число");
string number = Console.ReadLine()!;

if (number.Length == 5)
{
    int num1 = Convert.ToInt32(number[0]);
    int num2 = Convert.ToInt32(number[1]);
    int num3 = Convert.ToInt32(number[2]);
    int num4 = Convert.ToInt32(number[3]);
    int num5 = Convert.ToInt32(number[4]);
    if (num1 == num5 && num2 == num4)
    {
        Console.WriteLine($"Число {number} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {number} НЕ является палиндромом");
    }
}
else
{
    Console.WriteLine("Введено не корректное число. Пожалуйста повторите, попытку");
}
