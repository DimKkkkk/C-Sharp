// Задача4: D = 9,8 * a^2 + 5,52 * cos(t^5)

Console.Clear();

Console.WriteLine("Вычислить арифметическое выражение: D = 9,8 * a^2 + 5,52 * cos(t^5)");

Console.Write("Введите значение a: ");
uint a = GetNumberFromUser();

Console.Write("Введите значение t: ");
uint t = GetNumberFromUser();

double cos = Math.Round(Math.Cos(Math.Pow(t, 5)), 2);
double D = 9.8 * Math.Pow(a, 2) + 5.52 * cos;
Console.WriteLine(cos);
Console.Write($"D = 9.8 * {a}^2 + 5.52 * cos(t^5) = {Math.Round(D, 2)}");


uint GetNumberFromUser()
{
    while(true)
    {
        bool isCorrect = uint.TryParse(Console.ReadLine(), out uint num);
        if (isCorrect) return num;
        else Console.WriteLine("Ошибка ввода!");
    }
}