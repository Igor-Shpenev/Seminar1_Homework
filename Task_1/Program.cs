//Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
Console.Write("Input int first number: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input int second number: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

if (num_1 > num_2)
{
    Console.WriteLine($"The number {num_1} is greater than the number {num_2}");
}
else
{
    Console.WriteLine($"The number {num_2} is greater than number {num_1}");
}