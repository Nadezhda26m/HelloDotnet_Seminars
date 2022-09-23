// Напишите программу, которая на вход принимает число 
// и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).

Console.Clear();
int number = new Random().Next(-100, 101);
Console.Write("Задумано число ");
Console.WriteLine(number);
if (number % 2 == 0)
{
    Console.WriteLine("Число является четным");
}
else
{
    Console.WriteLine("Число не является четным");
}