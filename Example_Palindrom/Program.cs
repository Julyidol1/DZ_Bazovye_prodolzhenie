//Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, палиндромом ли это

Console.Write("Проверим палиндром ли это? Введи пятизначное число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] ==number[4]  && number [1] == number[3])
    {
        Console.WriteLine("Это палиндром");
    }
    else
    {
        Console.WriteLine("Это не палиндром");
    }
}
else
{
    Console.WriteLine("Это не пятизначное число");
}