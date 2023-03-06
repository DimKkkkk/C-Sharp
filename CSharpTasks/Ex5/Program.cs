// Задача5: L = 1,51 * cos(x^2) + 2 * x^3

Console.Clear();

Console.WriteLine("Вычислить арифметическое выражение: L = 1,51 * cos(x^2) + 2 * x^3");

Console.Write("Введите значение x: ");
uint x = GetNumberFromUser();

double cos = Math.Cos(x*x);
double L = 1.51 * cos + 2 * Math.Pow(x, 3);

Console.Write($"L = 1,51 * cos({x}^2) + 2 * {x}^3 = {Math.Round(L, 2)}");

uint GetNumberFromUser()
{
    while (true)
    {
        bool isCorrect = uint.TryParse(Console.ReadLine(), out uint num);
        if (isCorrect) return num;
        else Console.WriteLine("Ошибка ввода!");
    }
}
