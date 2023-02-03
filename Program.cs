// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Clear();
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 0)
    Console.WriteLine($"В числе {n} присутстсвует только одно чётное число: 0!");
else if (n < 0)
    Console.WriteLine("Введите число больше 1");
else {
Console.WriteLine($"В числе {n} присутстсвуют следующие натуральные числа:");
Recurs(n);
void Recurs(int num)
{
    Console.Write($"{num}, ");
    if (num == 1)
    {
        return;
    }
    Recurs(num - 1);
}
}

