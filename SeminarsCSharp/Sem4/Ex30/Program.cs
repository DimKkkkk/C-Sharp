﻿/* Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/
PrintArr(); 

void PrintArr () // используем метод void так как нам ничего не надо вводить и выводить

{
    Console.Write("["); // прописываем чтобы при выводе открывалась квадратная скобка
    for (int i = 0; i < 7; i++) // до 7 потому что в 15 строке мы дополнительно ещё раз сделаем вывод последнего восьмого элемента массива уже без цикла
    {
        Console.Write($"{new Random().Next(0,2)}, ");
    }
    Console.Write($"{new Random().Next(0,2)}"); // прописываем ещё раз чтобы в конце не было запятой и без цикла выдаст нам один раз случайное число
    Console.Write("]"); // прописываем чтобы закрывалась квадратная скобка
}

/* или вот вариант как можно решить и опять же кодом решить вопрос про последнюю запятую.
    Console.Write("["); 
    for (int i = 0; i < 8; i++) 
    {
        int num = new Random().Next(0,2);
        Console.Write($"{num}");
        if (i < 7) ConsoleWrite(", ");
    }
    Console.Write("]");
*/