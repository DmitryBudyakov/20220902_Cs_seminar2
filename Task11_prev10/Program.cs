// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);

int ToTwoDigitsNum(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    return 10 * firstDigit + thirdDigit;
}

// int newNumber = 10 * firstDigit + thirdDigit;

Console.WriteLine(number);
Console.WriteLine(ToTwoDigitsNum(number));
