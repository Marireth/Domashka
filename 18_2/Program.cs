// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

int Number1 = new int();
int Number2 = new int();
int Number3 = new int();

Console.Write("Введите первое число: ");
Number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
Number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
Number3 = Convert.ToInt32(Console.ReadLine());

int max = Number1;
if(Number1 > max) max = Number1;
if(Number2 > max) max = Number2;
if(Number3 > max) max = Number3;
Console.Write("Большее число: ");
Console.WriteLine(max);