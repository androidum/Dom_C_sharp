﻿//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.WriteLine("Требуется ввести два числа");
Console.WriteLine("Введите число 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2)
{
    Console.WriteLine("Вы ввели два одинаковых числа");
}
else if (num1 > num2)
    {
        Console.WriteLine($"Число {num1} больше {num2}");
    }
    else Console.WriteLine($"Число {num2} больше {num1}");
