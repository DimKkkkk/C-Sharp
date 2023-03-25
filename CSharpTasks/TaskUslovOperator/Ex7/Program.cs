/* Ввести с клавиатуры координаты точки А(x,y) и определить лежит ли
данная точка внутри окружности радиуса R. Центром окружности являет-
ся начало координат. Ответ вывести в виде сообщения. */

Console.Clear();

int GetCordsFromUser()
{
    while (true)
    {
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
        if (isCorrect) return num;
        else Console.WriteLine("Ошибка ввода!");
    }
}

void CheckPosition(int x, int y, int R)
{
    if (x > 0 && x < R && y > 0 && y < R) Console.Write($"лежит внутри окружности радиуса R = {R}.");
    else if (x < 0 && x > R - R * 2 && y > 0 && y < R) Console.Write($"лежит внутри окружности радиуса R = {R}.");
    else if (x < 0 && x > R - R * 2 && y < 0 && y > R - R * 2) Console.Write($"лежит внутри окружности радиуса R = {R}.");
    else if (x > 0 && x < R && y < 0 && y > R - R * 2) Console.Write($"лежит внутри окружности радиуса R = {R}.");
    else Console.Write($"не лежит внутри окружности радиуса R = {R}");
}

Console.Write("Введите координату Х: ");
int x = GetCordsFromUser();
Console.Write("Введите координату Y: ");
int y = GetCordsFromUser();
Console.WriteLine($"Координаты точки A({x}, {y})");
Console.WriteLine();

Console.Write("Введите радиус окружности R: ");
int R = GetCordsFromUser();

Console.WriteLine();
Console.Write($"Точка А с координатами ({x}, {y}) ");
CheckPosition(x, y, R);
