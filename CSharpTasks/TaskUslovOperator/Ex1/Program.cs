/* Ввести с клавиатуры два числа. Определить, что больше, сумма квадратов
или квадрат суммы этих чисел. Ответ вывести в виде сообщения.*/

Console.Clear();

Console.Write("Введите первое число: ");
uint Num1 = GetNumberFromUser();

Console.Write("Введите второе число: ");
uint Num2 = GetNumberFromUser();
uint sum1 = SumPow(Num1, Num2);
uint sum2 = SumOfPow(Num1, Num2);
Console.WriteLine();
uint check = CheckSum(sum1, sum2);
Console.WriteLine("Сумма квадратов чисел = " + sum1);
Console.WriteLine("Квадрат суммы чисел = " + sum2);
Console.WriteLine();
if (sum1 > sum2) Console.Write("Сумма квадратов чисел " + sum1 + "БОЛЬШЕ Квадрата суммы чисел" + sum2);
else Console.Write("Квадрат суммы чисел = " + sum2 + " БОЛЬШЕ Суммы квадратов чисел = " + sum1);


uint GetNumberFromUser()
{
    while (true)
    {
        bool isCorrect = uint.TryParse(Console.ReadLine(), out uint num);
        if (isCorrect) return num;
        else Console.WriteLine("Ошибка ввода!");
    }
}

uint SumPow(uint N1, uint N2)
{
    double res = Math.Pow(N1, 2) + Math.Pow(N2, 2);
    uint sum1 = Convert.ToUInt32(res);
    return sum1;
}

uint SumOfPow(uint N1, uint N2)
{
    double res = Math.Pow((N1 + N2), 2);
    uint sum2 = Convert.ToUInt32(res);
    return sum2;
}

uint CheckSum(uint sum1, uint sum2)
{
    if (sum1 > sum2) return sum1;
    else return sum2;
}