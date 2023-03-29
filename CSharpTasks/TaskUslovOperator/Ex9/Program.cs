/* Определить площадь квадрата (со стороной a) и окружности (радиуса R).
Определить, площадь какой из фигур больше. Значения a и R ввести с
клавиатуры. Ответ вывести в виде сообщения. */

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

void GetSquare(uint a, uint R)
{
    double S1, S2;
    S1 = a * a;
    S2 = Math.Round((Math.PI * (R * R)), 2);
    if (S1 > S2) Console.Write($"Площадь квадрата = {S1} больше площади окружности = {S2}.");
    else Console.Write($"Площадь окружности = {S2} больше площади квадрата = {S1}.");
}

Console.Write("Введите значение стороны квадрата: ");
uint a = GetNumberFromUser();
Console.WriteLine();
Console.Write("Введите значение радиуса окружности: ");
uint R = GetNumberFromUser();
Console.WriteLine();

GetSquare(a, R);
