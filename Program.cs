// int number = new Random().Next(100, 1000);

// int result = ((number / 100) * 10) + (number % 10);

// Console.WriteLine($"Номер={number}; result={result} ");

// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    if (number1%number2 == 0)
    {
    Console.WriteLine($"Число {number2} кратное числу {number1}");
    }
    else
    {
    Console.WriteLine($"Число {number2} не кратное числу {number1} остаток {number1%number2}");
    }
}
else
{
    Console.WriteLine($"Число {number2} больше {number1}");
}
