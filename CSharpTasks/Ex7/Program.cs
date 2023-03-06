// Задача7: N = m^2 + 2,8 * |m| + 0,55

Console.Clear();

Console.WriteLine("Вычислить арифметическое выражение: N = m^2 + 2,8 * |m| + 0,55");

Console.Write("Введите значение m: ");
int m = GetNumberFromUser();

double N = m * m + 2.8 * Math.Abs(m) + 0.55;

Console.WriteLine($"N = {m}^2 + 2,8 * |{m}| + 0,55 = {Math.Round(N, 2)}");


int GetNumberFromUser()
{
    while (true)
    {
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
        if (isCorrect) return num;
        else Console.WriteLine("Ошибка ввода!");
    }
}