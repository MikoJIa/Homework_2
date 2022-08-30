// Напишите программу, которая принимает на вход пять чисел и выводит сумму
// и среднее африфмитическое этих чисел.

int Prompt(string message)
{
    System.Console.Write(message);         // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue);     // Преобразует строку в целое число
    return result;                         // Возвращает результат 
}
int[] inputmassive(int Length)
{
    int[] massive = new int[Length];
    for (int i = 0; i < massive.Length; i++)
    {
        massive[i] = Prompt($"Введите {i} элемент >");
    }
    return massive;
}
    int Summ(int[] massive)
{        
    int summ = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        summ = summ + massive[i];
    }
    return summ;
}    
    int [] massive = inputmassive(3);
    int summ = Summ(massive);
    double average = summ / ((double)massive.Length);
    System.Console.WriteLine($"Сумма равна {summ}, Среднее число равно {average}");