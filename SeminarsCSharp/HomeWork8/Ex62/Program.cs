// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

/*Console.Clear();

// функция ввода значений
int Prompt(string message)
{
    System.Console.Write(message);                    // Вывести сообщение
    int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
    return result;                                    // Возвращает результат
}

int[,] SpirallyArray(int s)
{
    int begin = 0;
    int count = 0;
    int element = s * s;
    int[,] array1 = new int[s, s];
    while (count < element)
    {
        for (int i = begin; i < s; i++)
        {
            count++;
            array1[begin, i] = count;
        }
        for (int i = begin + 1; i < s; i++)
        {
            count++;
            array1[i, s - 1] = count;
        }
        for (int i = s - 2; i >= begin; i--)
        {
            count++;
            array1[s - 1, i] = count;
        }
        for (int i = s - 2; i >= begin+1; i--)
        {
            count++;
            array1[i, begin] = count;
        }
        s -=1;
        begin+=1;
    }
    return array1;
}

void PrintArray(int[,] matrix)              
{
    for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   // Столбец
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] Spiral = SpirallyArray(Prompt("Введите размер матрицы: "));
PrintArray(Spiral);*/

/*Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[,] nums = new int[size, size];

int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
    nums[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
        ++j;
    else if (i < j && i + j >= size - 1)
        ++i;
    else if (i >= j && i + j > size - 1)
        --j;
    else
        --i;
    ++num;
}

PrintArray(nums);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] / 10 <= 0)
                Console.Write($" {array[i,j]} ");

            else Console.Write($"{array[i,j]} ");
        }        
        Console.WriteLine("");
    }
}*/


//Выводим в консоль массив, заполненный от центра к периферии по часовой стрелке
/*int m = 5;
int n = 5;

//С помощью переменной s задаются числа внутри массива,
//начиная с 25 в данном случае.
int s = m * n;

//Объявляем и инициализируем массив.
int[,] array = new int[m, n];

//Заполняем периметр массива против часовой стрелке.
//Не забудьте поменять инкремент на декремент у переменной s.
for (int x = 0; x < m; x++)
{
    array[x, 0] = s;
    s--;
}

for (int y = 1; y < n; y++)
{
    array[m - 1, y] = s;
    s--;
}

for (int x = m - 2; x >= 0; x--)
{
    array[x, n - 1] = s;
    s--;
}

for (int y = n - 2; y >= 1; y--)
{
    array[0, y] = s;
    s--;
}

//Периметр заполнен. Продолжаем заполнять массив и задаём
//координаты ячейки, которую необходимо заполнить следующей.
int c = 1;
int d = 1;

while (s > 1)
{
    //В Java инициализированный интовый массив заполняется нулями.
    //Периметр мы заполнили числами, отличными от нулей.
    //Следующие циклы поочерёдно работают, заполняя ячейки.
    //Вложенный цикл останавливается, если следующая ячейка имеет 
    //значение, отличное от ноля. Ячейка, на которой остановился 
    //цикл, не заполняется. Из-за этого условие для выхода из внешнего
    //цикла - (s>1). Если Вы поставите 0, получится вечный цикл. 

    //Движемся вниз.
    while (array[c + 1, d] == 0)
    {
        array[c, d] = s;
        s--;
        c++;
    }
    //Движемся вправо.
    while (array[c, d + 1] == 0)
    {
        array[c, d] = s;
        s--;
        d++;
    }

    //Движемся вверх.
    while (array[c - 1, d] == 0)
    {
        array[c, d] = s;
        s--;
        c--;
    }

    //Движемся влево.
    while (array[c, d - 1] == 0)
    {
        array[c, d] = s;
        s--;
        d--;
    }

}

//При данном решении в центре всегда остаётся незаполненная ячейка.
//Убираем её при помощи следующего цикла.
for (int x = 0; x < m; x++)
{
    for (int y = 0; y < n; y++)
    {
        if (array[x, y] == 0)
        {
            array[x, y] = s;
        }
    }
}

//Выводим массив в консоль.
for (int x = 0; x < m; x++)
{
    for (int y = 0; y < n; y++)
    {
        if (array[x, y] < 10)
        {
            //Два пробела, чтобы в консоли столбцы были ровные.
            Console.Write(array[x, y] + ",  ");
        }
        else
        {
            Console.Write(array[x, y] + ", ");
        }
    }
    Console.WriteLine("");
}*/


//Заполнение массива по часовой стрелке от периферии к центру
//Заполним массив, количество строк мы обозначим m, а столбцов - n.
int m = 5;
int n = 5;

//С помощью переменной s задаются числа внутри массива начиная с 1.
int s = 1;

//Объявляем и инициализируем массив.
int[,] array = new int[m, n];

//Заполняем периметр массива по часовой стрелке.
for (int y = 0; y < n; y++)
{
    array[0, y] = s;
    s++;
}
for (int x = 1; x < m; x++)
{
    array[x, n - 1] = s;
    s++;
}
for (int y = n - 2; y >= 0; y--)
{
    array[m - 1, y] = s;
    s++;
}
for (int x = m - 2; x > 0; x--)
{
    array[x, 0] = s;
    s++;
}

//Периметр заполнен. Продолжаем заполнять массив и задаём
//координаты ячейки, которую необходимо заполнить следующей.
int c = 1;
int d = 1;

while (s < m * n)
{
    //В Java инициализированный интовый массив заполняется нулями.
    //Периметр мы заполнили числами, отличными от нулей.
    //Следующие циклы поочерёдно работают, заполняя ячейки.
    //Вложенный цикл останавливается, если следующая ячейка имеет 
    //значение, отличное от ноля. Ячейка, на которой остановился 
    //цикл, не заполняется.

    //Движемся вправо.
    while (array[c, d + 1] == 0)
    {
        array[c, d] = s;
        s++;
        d++;
    }

    //Движемся вниз.
    while (array[c + 1, d] == 0)
    {
        array[c, d] = s;
        s++;
        c++;
    }

    //Движемся влево.
    while (array[c, d - 1] == 0)
    {
        array[c, d] = s;
        s++;
        d--;
    }

    //Движемся вверх.
    while (array[c - 1, d] == 0)
    {
        array[c, d] = s;
        s++;
        c--;
    }
}

//При данном решении в центре всегда остаётся незаполненная ячейка.
//Убираем её при помощи следующего цикла.
for (int x = 0; x < m; x++)
{
    for (int y = 0; y < n; y++)
    {
        if (array[x, y] == 0)
        {
            array[x, y] = s;
        }
    }
}

//Выводим массив в консоль.
for (int x = 0; x < m; x++)
{
    for (int y = 0; y < n; y++)
    {
        if (array[x, y] < 10)
        {
            //Два пробела, чтобы в консоли столбцы были ровные.
            Console.Write(array[x, y] + ",  ");
        }
        else
        {
            Console.Write(array[x, y] + ", ");
        }
    }
    Console.WriteLine("");
}

