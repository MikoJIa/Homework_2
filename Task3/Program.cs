// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе
// число кратным первому.

int Prompt(string message)
{
    System.Console.Write(message);         // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue);     // Преобразует строку в целое число
    return result;                         // Возвращает результат 
}

int num1;
int num2;
int ost;
num1 = Prompt("Введите первое число >");
num2 = Prompt("Введите второе число >");
ost = (num1 % num2);
if (ost == 0){
    System.Console.WriteLine("Кратно");
}
else
{
    System.Console.WriteLine($"Не кратно");
}