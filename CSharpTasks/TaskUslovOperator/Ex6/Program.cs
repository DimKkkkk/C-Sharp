/* Ввести с клавиатуры координаты точки А(x,y). Определить, в какой чет-
верти лежит данная точка. Ответ вывести в виде сообщения.*/

int GetNumberFromUser()
{
    while (true)
    {
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
        if (isCorrect) return num;
        else Console.WriteLine("Оишбка ввода!");
    }
}

void CheckPosition(int x, int y)
{
    if (x > 0 && y > 0) Console.Write(" лежит в 1-ой четверти координат.");
    else if (x < 0 && y > 0) Console.Write(" лежит во 2-ой четверти координат.");
    else if (x < 0 && y < 0) Console.Write(" лежит в 3-ей четверти координат.");
    else if (x > 0 && y < 0) Console.Write(" лежит в 4-ой четверти координат.");
    else Console.WriteLine("Введите значение координат не равные нулю!");
}

Console.Clear();

Console.WriteLine("Определяем ы какой четверти оси координат лежит точка А...");
Console.WriteLine();
Console.Write("Введите координату Х: ");
int x = GetNumberFromUser();

Console.Write("Введите координату Y: ");
int y = GetNumberFromUser();

Console.Write($"Координаты точки А({x}, {y})");
Console.WriteLine();
Console.WriteLine();
Console.Write($"Точка A с координатами ({x}, {y})");
CheckPosition(x, y);
Console.WriteLine();