// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
// 7 и 23.

int Prompt(string message)
{
    System.Console.Write(message);         // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue);     // Преобразует строку в целое число
    return result;                         // Возвращает результат 
}

int num = Prompt("Введите число >");
if (num % 7 == 0 && num % 23 == 0)
{
    System.Console.WriteLine("Кратно");
} else
{
    System.Console.WriteLine("Не кратно");
}

