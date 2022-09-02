// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int a = 7, b = 23;  // числа, на кратность которым будем проверять число num

bool IsCratno(int number, int num1, int num2)   // подаем на вход число и делители, на кратность которых надо проверить
{
    return (number % num1 == 0 && number % num2 == 0);
}

bool result = IsCratno(num, a, b);
if (result) Console.WriteLine($"Число {num} кратно числам {a} и {b}");
else Console.WriteLine($"Число {num} не кратно числам {a} и {b}");
