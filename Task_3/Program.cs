// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
Console.Write("Input int number: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num % 2;

if(result==1){
    Console.WriteLine($"Number {num} is odd");
}
else
{
    Console.WriteLine($"Namber {num} is even");
}