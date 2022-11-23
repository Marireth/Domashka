// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

int Number = new int();
Console.WriteLine("Является ли число чётным?");
Console.Write("Введите число: ");
Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Number % 2 == 0);