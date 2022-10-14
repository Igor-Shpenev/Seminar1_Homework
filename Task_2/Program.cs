// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input int first number: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input int second number: ");
int num_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("input int third number: ");
int num_3 = Convert.ToInt32(Console.ReadLine());
int max = num_1;

if (num_2 > max)
{
    max = num_2;
}
if (num_3 > max)
{
    max = num_3;
}

Console.WriteLine($"Maximum number is {max}");

