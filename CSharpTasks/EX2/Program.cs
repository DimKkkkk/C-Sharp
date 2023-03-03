//Задача1: K= ln(p^2+y^3)+e^p

Console.Clear();

Console.WriteLine("Вычислить арифметическое выражение: K = ln(p^2 + y^3) + e^p");

Console.Write("Введите значение p: ");
uint p = GetNumberFromUser();

Console.Write("Введите значение y: ");
uint y = GetNumberFromUser();

double e = Math.Exp(p);
double brace = Math.Pow(p, 2) + Math.Pow(y, 3);
double ln = Math.Log(brace);

Console.Write($"K = ln({p}^2 + {y}^3) + e^{p} = {Math.Round((ln + e), 2)}");

uint GetNumberFromUser()
{
    while (true)
    {
        bool isCorrect = uint.TryParse(Console.ReadLine(), out uint num);
        if (isCorrect) return num;
        else Console.WriteLine("Ошибка ввода!");
    }
}