// Задача 8: T = √|6 * y² - 0.1 * y + 4|

/*Console.Clear();

Console.WriteLine("Вычислить арифметическое выражение: T = √|6 * y² - 0.1 * y + 4|");

Console.Write("Введите значение y: ");
uint y = GetNumberFromUser();

double T = Math.Sqrt(Math.Abs(6 * y * y - 0.1 * y + 4));
Console.WriteLine($"T = √|6 * {y}² - 0.1 * {y} + 4| = {Math.Round(T, 2)}");


uint GetNumberFromUser()
{
	while (true)
	{
		bool isCorrect = uint.TryParse(Console.ReadLine(), out uint num);
		if (isCorrect) return num;
		else Console.WriteLine("Ошибка ввода!");
    }
}
*/
//================================================================

//Задача 9: V = ln(y + 0.95) + sin(x^4)
/*
Console.Clear();

Console.WriteLine("Вычислить арифметическое выражение: V = ln(y + 0.95) + sin(x^4)");

Console.Write("Введите значение y: ");
uint y = GetNumberFromUser();

Console.Write("Введите значение x: ");
uint x = GetNumberFromUser();

double V = Math.Log(y + 0.95) + Math.Sin(Math.Pow(x, 4));
Console.WriteLine($"V = ln({y} + 0.95) + sin({x}^4) = {Math.Round(V, 2)}");

uint GetNumberFromUser()
{
	while (true)
	{
		bool isCorrect = uint.TryParse(Console.ReadLine(), out uint num);
		if (isCorrect) return num;
		else Console.WriteLine("Ошибка ввода!");
	}
}
*/
//===================================================================

//Задача 10: U = e^y + 7,355 * k² + sin²(x)
/*
Console.Clear();

Console.WriteLine("Вычислить арифметическое выражение: U = e^y + 7,355 * k² + sin²(x)");

Console.Write("Введите значение y: ");
uint y = GetNumberFromUser();

Console.Write("Введите значение k: ");
uint k = GetNumberFromUser();

Console.Write("Введите значение x: ");
uint x = GetNumberFromUser();

double U = Math.Exp(y) + 7.355 * k * k + Math.Pow(Math.Sin(x), 2);
Console.WriteLine($"U = e^{y} + 7,355 * {k}² + sin²({x}) = {Math.Round(U, 2)}");

uint GetNumberFromUser()
{
	while (true)
	{
		bool isCorrect = uint.TryParse(Console.ReadLine(), out uint num);
		if (isCorrect) return num;
		else Console.WriteLine("Ошибка ввода!");
	}
}
*/
//=====================================================

//Задача 11: S = 9,756 * y^7 + 2 * tg(x)
/*
Console.Clear();

Console.WriteLine("Вычислить арифметическое выражение: S = 9,756 * y^7 + 2 * tg(x)");

Console.Write("Введите значение y: ");
uint y = GetNumberFromUser();

Console.Write("Введите значение x: ");
uint x = GetNumberFromUser();

double S = 9.756 * Math.Pow(y, 7) + 2 * Math.Tan(x);
Console.WriteLine($"S = 9,756 * {y}^7 + 2 * tg({x}) = {Math.Round(S, 2)}");

uint GetNumberFromUser()
{
	while (true)
	{
		bool isCorrect = uint.TryParse(Console.ReadLine(), out uint num);
		if (isCorrect) return num;
		else Console.WriteLine("Ошибка ввода!");
	}
}
*/
//==========================================

//Задача 12: K = 7 * t² + 3 * sin(x³) + 9,2

Console.Clear();

Console.WriteLine("Вычислить арифметическое выражение: K = 7 * t² + 3 * sin(x³) + 9,2");

Console.Write("Введите значение t: ");
uint t = GetNumberFromUser();

Console.Write("Введите значение x: ");
uint x = GetNumberFromUser();

double K = 7 * t * t + 3 * Math.Sin(Math.Pow(x, 3)) + 9.2;
Console.WriteLine($"K = 7 * {t}² + 3 * sin({x}³) + 9,2 = {Math.Round(K, 2)}");


uint GetNumberFromUser()
{
	while (true)
	{
		bool isCorrect = uint.TryParse(Console.ReadLine(), out uint num);
		if (isCorrect) return num;
		else Console.WriteLine("Ошибка ввода!");
	}
}
