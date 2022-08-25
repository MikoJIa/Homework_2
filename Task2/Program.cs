// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

int Prompt(string message)
{
    System.Console.Write(message);         // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue);     // Преобразует строку в целое число
    return result;                         // Возвращает результат 
}

int number;
number = new Random().Next(10, 100);
System.Console.WriteLine(number);
int number1 = number % 10;
int number2 = number / 10;
if (number1 > number2)
{
    System.Console.WriteLine($"Максимальное число {number1}");
}
else
{
    System.Console.WriteLine($"Максимальное число {number2}");
}
