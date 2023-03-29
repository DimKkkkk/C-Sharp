/* Ввести с клавиатуры значения сторон двух треугольников a1,b1,c1 и
a2,b2,c2. Определить, площадь какого треугольника – наибольшая. Ответ
вывести в виде сообщения. */

Console.Clear();

uint GetNumberFromUser()
{
    while (true)
    {
        bool isCorrect = uint.TryParse(Console.ReadLine(), out uint num) && (num > 0);
        if (isCorrect) return num;
        else Console.WriteLine("Ошибка ввода!");
    }
}

double GetSquareTriangle(uint a, uint b, uint c)
{
    double S = 0;
    if (a + b > c && a + c > b && b + c > a)
    {
        double p = (a + b + c) / 2;
        S = Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2);
    }
    else Console.Write("Вы ввели не треугольник ");
    return S;
}

Console.WriteLine("Введите значения сторон 1-го треугольника...");
uint a1 = GetNumberFromUser();
uint b1 = GetNumberFromUser();
uint c1 = GetNumberFromUser();

Console.WriteLine();

Console.WriteLine("Введите значения сторон 2-го треугольника...");
uint a2 = GetNumberFromUser();
uint b2 = GetNumberFromUser();
uint c2 = GetNumberFromUser();

Console.WriteLine();

Console.Write($"Площадь 1-го треугольника = {GetSquareTriangle(a1, b1, c1)}");

Console.WriteLine();

Console.Write($"Площадь 2-го треугольника = {GetSquareTriangle(a2, b2, c2)}");

Console.WriteLine();
Console.WriteLine();
if (GetSquareTriangle(a1, b1, c1) > GetSquareTriangle(a2, b2, c2)) Console.Write("Площадь 1-го треугольника больше!");
else Console.Write("Площадь 2-го треугольника больше!");