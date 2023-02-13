﻿/* Задача 39: Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

Console.Clear();
Console.WriteLine("Выполняется создание массива... ");
Console.WriteLine();
int[] array = GetArray(10, 0, 10);  // создаём массив
Console.Write($"[{String.Join(", ", array)}] -> ");

int[] reversArray = ReversArray1(array); // вызываем метода разворота и этому методу передаём наш массив array.
Console.WriteLine($"[{String.Join(", ", reversArray)}]");

Console.WriteLine();

ReversArray2(array); // а это второй вариант разворота нашего массива. Здесь мы просто вызываем метод ReversArray2.
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++) // цикл для заполнения нашего массива
    {
        res[i] = new Random().Next(minValue, maxValue + 1); // +1 чтобы макс значение было включительно, до 10 включительно.
    }
    return res;
}

int[] ReversArray1(int[] inArray) // этот вариант хуже если размер массива будет очень большим от 1 млн и более. 
//Он занимает больше памяти. мы создаём новый массив куда будем сохранять новые переменные, а это занимает память. И его используем когда нам надо сохранить исходный массив
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i]; // проходим справа налево и переставляем значения нашего массива местами
    }
    return result;
}

void ReversArray2(int[] inArray) // Когда нам нужно просто изменить наш исходный массив и не запоминать исходный.
//это решение второго варианта с экономичным использованием памяти, когда мы просто вызываем метод без присваивания 
//нового метода через int в самом начале.
{
    for (int i = 0; i < inArray.Length / 2; i++) // делим наш массив пополам. когда нечётное, например 7 элементов в массиве, 
    //то разделит на 3 и 4, и центральный элемент будет без движений.
    {
        int k = inArray[i]; // создаём временную переменную и сохраняем для начала в него первый элемент под индексом 0. начинаем же от i=0.
        inArray[i] = inArray[inArray.Length - i - 1]; // здесь мы берём последний элемент в массиве и копируем его в элемент под индекс 0, так как i=0.
        inArray[inArray.Length - i - 1] = k; // а здесь уже вставляем наш первый элемент, который мы сохранили во временной переменной k.
    }
}