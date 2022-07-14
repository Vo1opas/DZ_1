//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт максимальное из этих чисел.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int a;
int b;

Console.Write("Enter number 1 ");
a = int.Parse(Console.ReadLine());
Console.Write("Enter number 2 ");
b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.Write(a);

}
else
{
    Console.Write(b);

}