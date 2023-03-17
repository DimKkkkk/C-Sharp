/* Ввести с клавиатуры три числа, положительные возвести в квадрат, а
отрицательные оставить без изменений.*/

/*int GetNumberFromUser()
{
    while (true)
    {
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
        if (isCorrect) return num;
        else Console.WriteLine("Ошибка ввода!");
    }
}

int CheckNum(int num)
{
    if (num > 0) return num * num;
    else return num;

}*/

int[] GetValue(int size)
{
    int[] value = new int[size];
    for (int i = 0; i < size; i++)
    {
        value[i] = int.Parse(Console.ReadLine() ?? "");
    }
    return value;
}

void PrintValue(int[] value)
{
    for (int i = 0; i < value.Length; i++)
    {
        if (i < value.Length - 1) Console.Write($"{value[i]}, ");
        else Console.Write($"{value[i]}");
    }
    Console.WriteLine();
}

void CheckNumAndPow(int[] value)
{
    for (int i = 0; i < value.Length; i++)
    {
        if (value[i] > 0) value[i] = value[i] * value[i];

    }
}

Console.Write("Введите количество значений: ");
int size = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine($"Введите {size} значения: ");
int[] value = GetValue(size);
Console.WriteLine();
Console.Write("Полученные значения: ");
PrintValue(value);
Console.WriteLine();
Console.Write("Положительные значения возвести в квадрат, отрицательные оставить без изменений... ");
Console.WriteLine();
CheckNumAndPow(value);
Console.Write("Результат: ");
PrintValue(value);
/*Console.Write("Введите второе значение: ");
int B = GetNumberFromUser();
Console.Write("Введите третье значение: ");
int C = GetNumberFromUser();

Console.WriteLine();
Console.Write($"{CheckNum(A)}, ");
Console.Write($"{CheckNum(B)}, ");
Console.Write($"{CheckNum(C)}");*/