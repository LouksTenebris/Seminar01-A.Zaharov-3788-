﻿//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

int a = 1;
bool not = true;
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Чётные числа от 1 до ");
Console.WriteLine(number);

while (a <= number)
{
    if (a % 2 != 1)
    {
        Console.Write(a + ", ");
        not = false;
    }
    a++;
}

if (not)
{
    Console.WriteLine("Нет чётных чисел!");
}