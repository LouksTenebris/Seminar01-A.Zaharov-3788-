//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

System.Console.Write("Введите первое число: ");
int number_one = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int number_second = Convert.ToInt32(Console.ReadLine());

if (number_one > number_second)
{
    Console.Write("Max = ");
    Console.WriteLine(number_one);
    Console.Write("Min = ");
    Console.WriteLine(number_second);
}
else
{
    Console.Write("Max = ");
    Console.WriteLine(number_second);
    Console.Write("Min = ");
    Console.WriteLine(number_one);
}
