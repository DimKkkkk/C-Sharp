/* Задача 11. Дано натуральное число. Определить, является ли оно четным, или окан-
чивается цифрой 3.*/

Console.Clear();

uint GetNumFromUser()
{
    while (true)
    {
        bool isCorrect = uint.TryParse(Console.ReadLine(), out uint num);
        if (isCorrect) return num;
        else Console.WriteLine("Ошибка ввода!");
    }
}

void CheckValue(uint N)
{
    if (N % 2 == 0) Console.Write($"Число {N} является чётным.");
    else if (N % 10 == 3) Console.Write($"Число {N} оканчивается цифрой 3.");
    else Console.Write($"Число {N} является НЕчётным.");
}

Console.Write("Введите натуральное число: ");
uint N = GetNumFromUser();

Console.WriteLine();
CheckValue(N);