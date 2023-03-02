//Задача1: R=3*t^2+3*l^5+4.9

Console.Clear();

Console.Write("Вычислить арифметическое выражение R = 3 * t^2 + 3 * l^5 + 4.9");
Console.WriteLine();

Console.Write("Введите значение t: ");
uint t = GetNumberFromUser();

Console.Write("Введите значение l: ");
uint l = GetNumberFromUser();

double R = 3 * Math.Pow(t, 2) + 3 * Math.Pow(l, 5) + 4.9;
Console.Write($"R = 3 * {t}^2 + 3 * {l}^5 + 4.9 = {R}");

uint GetNumberFromUser()
{
    while (true)
    {
        bool isCorrect = uint.TryParse(Console.ReadLine(), out uint num);
        if (isCorrect) return num;
        else Console.WriteLine("Ошибка ввода!");
    }
}
