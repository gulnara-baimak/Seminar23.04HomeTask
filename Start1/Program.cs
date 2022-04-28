// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
System.Console.WriteLine($"Введите число: ");
int number = Convert.ToInt16(Console.ReadLine());
int oldValue = number;
int newValue = 0;
    while (number > 0)
        {
        int dig = number % 10; // деление с остатком
        newValue = newValue * 10 + dig;
        number = number / 10; // деление нацело
        }
            if (newValue == oldValue) 
            {
            System.Console.WriteLine($"Палиндром!");
            }
                else  
                { 
                Console.WriteLine("Не палиндром!");
                }

