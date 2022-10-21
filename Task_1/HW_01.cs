// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

int UserNumberM = GetNumberMFromUser("Введите число M (сколько чисел Вы хотите ввести): ", "Ошибка ввода!");

int[] UserArray = GetArray(UserNumberM);

int count = GetPositiv(UserArray);

Console.WriteLine($"Из {UserNumberM} введённых Вами чисел, {count} больше 0");

////////// Определение методов///////////
int GetNumberMFromUser(string message, string errorMessage)
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

int[] GetArray(int size)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = EnterNumber(i + 1);
    }
    return res;
}

int EnterNumber(int Num)
{
    int number;
    while (true)
    {
        Console.Write($"Введите {Num} число: ");
        if (int.TryParse(Console.ReadLine(), out number)) break;
        else Console.WriteLine($"Ошибка ввода!");
    }
    return number;
}

int GetPositiv(int[] array)
{
    int countPositiv = 0;
    foreach (int el in array)
    {
        if (el > 0) countPositiv++;
    }
    return countPositiv;
}