// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int a;
int b;
int c;
int max;

Console.Write("Enter number 1 ");
a = int.Parse(Console.ReadLine());
Console.Write("Enter number 2 ");
b = int.Parse(Console.ReadLine());
Console.Write("Enter number 3 ");
c = int.Parse(Console.ReadLine());

max = a;

if (max < b )
{
    max = b;

}
if (max < c)
{
    max = c;

}
Console.Write(max);