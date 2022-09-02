// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine(number);

int firstDigit = number / 10;   // находим 1-ю цифру числа
int secondDigit = number % 10;   // находим 2-ю цифру числа

// if(firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {number} -> {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа {number} -> {secondDigit}");

// через тернарный оператор
if (firstDigit == secondDigit) Console.WriteLine("Цифры равны");
else
{
    int max = firstDigit > secondDigit ? firstDigit : secondDigit;
    Console.WriteLine($"Наибольшая цифра числа {number} -> {max}");
}
