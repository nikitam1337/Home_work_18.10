// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

Console.WriteLine($"Прямые заданы уравнениями: y = k1 * x + b1, y = k2 * x + b2:");
Console.WriteLine($"Для нахождения точки пересечения прямых необходимо задать значения b1, k1, b2, k2");

int b1 = GetNumberFromUser("Введите число b1: ", "Ошибка ввода!");
int k1 = GetNumberFromUser("Введите число k1: ", "Ошибка ввода!");
int b2 = GetNumberFromUser("Введите число b2: ", "Ошибка ввода!");
int k2 = GetNumberFromUser("Введите число k2: ", "Ошибка ввода!");


double x = ((double)b2 - b1) / (k1 - k2);
double y = (double)k1 * x + b1;

Console.WriteLine($"Точка пересечения двух заданных прямых имеет координату: ({x}; {y})");

////////// Определение методов///////////
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

