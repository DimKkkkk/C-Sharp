/* Задача 15 Ввести с клавиатуры координаты точек А(х0, у0) и В(х1, у1). Определить,
какая из точек А или В наименее удалена от начала координат (О(0,0)).
Ответ вывести в виде сообщения.*/

Console.Clear();

void EnterCords(ref int X, ref int Y)
{
    try
    {
        Console.Write("Введите координату Х: ");
        X = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите координату Y: ");
        Y = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return;
    }
}

int x0 = 0, y0 = 0, x1 = 0, y1 = 0;

void MinDistance()
{
    double A = Math.Sqrt(Math.Pow(x0, 2) + Math.Pow(y0, 2));
    double B = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
    if (A > B) Console.Write($"Точка B ({x1}, {y1})");
    else Console.Write($"Точка A ({x0}, {y0})");
}

EnterCords(ref x0, ref y0);
Console.WriteLine();
Console.WriteLine($"Координаты точки А ({x0},{y0})");
Console.WriteLine();
EnterCords(ref x1, ref y1);
Console.WriteLine();
Console.WriteLine($"Координаты точки B ({x1},{y1})");
Console.WriteLine();
MinDistance();
Console.Write($" наименее удалённая точка от начала координат O (0, 0).");