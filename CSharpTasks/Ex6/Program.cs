// Задача6: M = cos(2 * y) + 3,6 * (e^x)

Console.Clear();

Console.WriteLine("Вычислить арифметическое выражение: M = cos(2 * y) + 3,6 * (e^x)");

Console.Write("Введите значение y: ");
uint y = GetNumberFromUser();

Console.Write("Введите значение x: ");
uint x = GetNumberFromUser();

double cos = Math.Cos(2 * y);
double exp = Math.Exp(x);
double M = cos + 3.6 * exp;

Console.WriteLine(cos);
Console.WriteLine($"M = cos(2 * {y}) + 3,6 * (e^{x}) = {Math.Round(M, 2)}");


uint GetNumberFromUser()
{
    while (true)
    {
        bool isCorrect = uint.TryParse(Console.ReadLine(), out uint num);
        if (isCorrect) return num;
        else Console.WriteLine("Ошибка ввода!");
    }
}
