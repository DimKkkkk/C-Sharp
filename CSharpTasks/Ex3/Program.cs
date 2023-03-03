// Задача3: G = n(y+3.5)+√y)

Console.Clear();

Console.WriteLine("Вычислить арифметическое выражение: G = n * (y + 3.5) + √y)");
Console.Write("Введите значение n: ");
uint n = GetNumberFromUser();

Console.Write("Введите значение y: ");
uint y = GetNumberFromUser();

double G = n * (y + 3.5) + Math.Sqrt(y);

Console.Write($"G = {n} * ({y} + 3.5) + √{y} = {Math.Round(G, 2)}");

uint GetNumberFromUser()
{
    while (true)
    {
        bool isCorrect = uint.TryParse(Console.ReadLine(), out uint num);
        if (isCorrect) return num;
        else Console.WriteLine("Ошибка ввода!");
    }
}