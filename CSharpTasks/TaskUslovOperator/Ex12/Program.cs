/* Задача12. Ввести с клавиатуры координаты точки А(x,y). Определить, лежит ли
данная точка в первой четверти. Ответ вывести в виде сообщения.*/

Console.Clear();

int GetCordsFromUser()
{
    while (true)
    {
        bool isCorrect= int.TryParse(Console.ReadLine(), out int num);
        if (isCorrect) return num;
        else Console.WriteLine("Ошибка ввода!");
    }
}

void CheckCords(int x, int y)
{
    if (x > 0 && y > 0 ) Console.Write(" лежит в Первой четверти.");
    else if (x == 0 || y == 0) Console.Write(" лежит на плоскости координат!");
    else Console.Write(" НЕ лежит в первой четверти!");
}

Console.WriteLine("Введите координаты точки А...");
Console.WriteLine();
Console.Write("Введите координату Х: ");
int x = GetCordsFromUser();
Console.WriteLine();
Console.Write("Введите координату Y: ");
int y = GetCordsFromUser();
Console.WriteLine();
Console.Write($"Точка А ({x}, {y})");
CheckCords(x, y);