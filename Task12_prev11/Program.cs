// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool checkNumbers(int nummber1, int number2)
{
    return nummber1 % number2 == 0;
}
// string checkNumbers(int nummber1, int number2)
// {
//     int ost = nummber1 % number2;
//     return ost == 0 ? "кратно" : $"не кратно, остаток {ost}";
// }

if (num1 > num2)
{
    bool result = checkNumbers(num1, num2);
    int ost = num1 % num2;

    if (result) Console.WriteLine("кратно");
    else Console.WriteLine($"не кратно, остаток {ost}");
}
else Console.WriteLine("Введите другие числа");
