//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

System.Console.Write("Введите первое число: ");
int number_one = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int number_second = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третье число: ");
int number_third = Convert.ToInt32(Console.ReadLine());

if (number_one > number_second)
{
    if (number_one > number_third);
    {
        Console.Write("Max = ");
        Console.WriteLine(number_one);
    }
}
else if (number_second > number_third)
{
        Console.Write("Max = ");
        Console.WriteLine(number_second);
}
else
{
    Console.Write("Max = ");
    Console.WriteLine(number_third);
}