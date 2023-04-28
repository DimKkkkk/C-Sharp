/* Задача 14 Ввести с клавиатуры два числа. Определить, что больше, разность квадра-
тов или модуль квадрата разности этих чисел. Ответ вывести в виде
сообщения.*/

Console.Clear();

int GetNumFromUser()
{
    while (true)
    {
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
        if (isCorrect) return num;
        else Console.WriteLine("Ошибка ввода!");
    }
}

void CompareResult(int A, int B)
{
    double res1 = Math.Pow(A, 2) - Math.Pow(B, 2);
    double res2 = Math.Pow(Math.Abs(A - B), 2);
    if (res1 > res2) Console.Write($"Разность квадратов {A} и {B} = {res1} БОЛЬШЕ модуля квадрата разности {A} и {B} = {res2}.");
    else if (res2 > res1) Console.Write($"Модуль квадрата разности {A} и {B} = {res2} БОЛЬШЕ разности квадратов {A} и {B} = {res1}.");
    else Console.Write("Результаты РАВНЫ");
}

Console.Write("Введите число А: ");
int A = GetNumFromUser();
Console.WriteLine();
Console.Write("Введите число B: ");
int B = GetNumFromUser();
Console.WriteLine();

CompareResult(A, B);