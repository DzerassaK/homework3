// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int temp = 0;
int reverse = 0;
if (number < 10000 || number > 99999)
{
    Console.WriteLine("Число не пятизначное, попробуйте снова");
}
else
{
    for (temp = number; number > 10000; number = number / 10)
    {
        int rem = number % 10;
        reverse = reverse * 10 + rem;
    }
    if (temp == reverse)
        Console.WriteLine("Число является палиндромом");

    else

        Console.WriteLine("Число не является палиндромом");
}
