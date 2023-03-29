/* Ввести с клавиатуры три числа, положительные возвести в куб, а отрица-
тельные заменить на 0. */

Console.Clear();

int GetNumFromUser()
{
    while (true)
    {
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num) && (num != 0);
        if (isCorrect) return num;
        else Console.WriteLine("Ошибка ввода!");
    }
}

int[] FillNumFromUser(int Q)
{    
    int[] res = new int[Q];
    for (int i = 0; i < res.Length; i++)
    {
        Console.Write($"Введите число: ");
        res[i] = GetNumFromUser();         
    }
    return res;
}

void PrintChisla(int[] chisla)
{
    Console.Write("[");
    for (int i = 0; i < chisla.Length; i++)
    {        
        if(i < chisla.Length - 1) Console.Write($"{chisla[i]}, ");
        else Console.Write($"{chisla[i]}]");
    }
    Console.WriteLine();
}

void ChangeChisla(int[] chisla)
{   
    for (int i = 0; i < chisla.Length; i++)
    {
        if(chisla[i] > 0) chisla[i] = Convert.ToInt32(Math.Pow(chisla[i], 3));
        else chisla[i] = 0;
    }
}

Console.Write("Введите количество чисел для ввода: ");
int Q = GetNumFromUser();
int[] chisla = FillNumFromUser(Q);
Console.WriteLine();

PrintChisla(chisla);
Console.WriteLine();
ChangeChisla(chisla);
Console.WriteLine();
PrintChisla(chisla);
Console.WriteLine();


