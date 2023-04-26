/* Задача 13 Рассчитать сумму ежемесячных выплат процентов по депозиту, если
договор составлен на полгода под 6% годовых или на год под 8% годовых.
С клавиатуры ввести сумму вклада и срок договора.*/

Console.Clear();

uint GetNumFromUser ()
{
    while (true)
    {
        bool isCorrect = uint.TryParse(Console.ReadLine(), out uint num) && (num != 0);
        if(isCorrect) return num;
        else Console.WriteLine("Ошибка ввода!");
    }
}

void SumOfDeposit (uint Sum, uint period)
{    
    uint P = 0;
    uint res = Sum;
    if (period * 30 > 360 || period *30 < 180) Console.WriteLine("дурак!");
    for(int i = 0; i < period; i++)
    {        
        if(period * 30 == 360)
        {
            P = (Sum*8*30/360)/100;
            res += P;
        }        
        else if (period * 30 == 180)
        {
            P = (Sum*6*30/360)/100;
            res += P;
        }                        
    }
    Console.Write($"{res-Sum}");
}

Console.WriteLine("Введите вклад: ");
uint Sum = GetNumFromUser();
Console.WriteLine("Введите период: ");
uint period = GetNumFromUser();

SumOfDeposit(Sum, period);