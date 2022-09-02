// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

// Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

bool IsSquared(int a1, int b1)
{
    return (a1 * a1 == b1 || b1 * b1 == a1);
}

bool result = IsSquared(a, b);

if (result) Console.WriteLine($"Да, одно число является квадратом другого.");
else Console.WriteLine($"Нет, одно число не является квадратом другого.");
