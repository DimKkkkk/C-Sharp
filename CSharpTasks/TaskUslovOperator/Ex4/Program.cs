/*Ввести с клавиатуры значения трех сторон треугольника a, b и c и опреде-
лить, является ли он прямоугольным. Ответ вывести в виде сообщения.*/

Console.Clear();
Console.Write("Введите значение треугольника стороны А: ");
uint A = GetNumberFromUser();

Console.Write("Введите значение треугольника стороны В: ");
uint B = GetNumberFromUser();

Console.Write("Введите значение треугольника стороны C: ");
uint C = GetNumberFromUser();

uint GetNumberFromUser()
{
    while (true)
    {
        bool isCorrect = uint.TryParse(Console.ReadLine(), out uint num);
        if (isCorrect) return num;
        else Console.WriteLine("Ошибка ввода!");
    }
}

void CheckTriangle()
{
    if (C == Math.Sqrt(A * A + B * B) ||
    B == Math.Sqrt(A * A + C * C) ||
    A == Math.Sqrt(C * C + B * B)) Console.Write("Этот треугольник прямоугольный");
    else Console.Write("Этот треугольник хрен пойми какой!");
}

CheckTriangle();