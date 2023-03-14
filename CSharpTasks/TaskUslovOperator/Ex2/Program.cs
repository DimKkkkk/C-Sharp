/* Задача2: Рассчитать надбавку к зарплате за стаж, если стаж от 2 до 5 лет, надбавка
составляет 2%, если стаж от 5 до 10 лет - 5%. Ввести с клавиатуры зар-
плату и стаж, вывести надбавку и сумму к выплате. */

Console.Clear();

Console.WriteLine("Рассчет надбавки за стаж...");
Console.WriteLine();

Console.Write("Введите размер зарплаты: ");
uint zarplata = GetNumberFromUser();

Console.WriteLine();

Console.Write("Введите стаж лет: ");
uint staj = GetNumberFromUser();

Console.WriteLine();

double nadbavka = GetNadbav(staj);
string str = string.Format("{0:p0}", nadbavka);

double sumzp = SumOfZp(zarplata, nadbavka);

Console.Write($"Надбавка за стаж составляет: " + str + " . Сумма к выплате: " + sumzp);


uint GetNumberFromUser()
{
	while (true)
	{
		bool isCorrect = uint.TryParse(Console.ReadLine(), out uint num);
                if (isCorrect) return num;
                else Console.WriteLine("Ошибка ввода!");
        }
}

double GetNadbav(uint staj)
{
	double res = 0;
        if (staj < 2) res = 0.0;
        else if (staj == 2 || staj < 5) res = 0.02;
        else if (staj == 5 || staj < 11) res = 0.05;
            return res;
}

double SumOfZp(uint zarplata, double nadbavka)
{
	double sum = zarplata * nadbavka + zarplata;
	return sum;
}