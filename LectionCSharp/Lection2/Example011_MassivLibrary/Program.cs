﻿// Делаем методы заполнения массива и метод печати его на экран
// Метод void - в C# есть методы(функции) которые могут возвращать какие-то значения, а каие-то нет. void не возвращает. вот в коде нам тогда не надо использовать оператор return;
void FillMassiv(int[] argumenty) // этот void который Fill - заполняет массив
{
    int length = argumenty.Length;  // получаем длину нашего массива
    int index = 0;
    while (index < length)
    {
        argumenty[index] = new Random().Next(1, 10);  // обращаемся к argumenty на позицию index и положить туда новое случайное число от 1 до 10. Т.е. массив будет заполняться случайными числами.
        index++;
    }
}

void PrintMassiv(int[] arg) // этот void будет печатать массив. и даём другое название аргументу arg
{
    int count = arg.Length; //количество элементов обозначаем в массиве
    int position = 0; // позицию обозначаем от нуля
    while (position < count)
    {
        Console.WriteLine(arg[position]); // выводим на экран значение текущего элемента
        position++;
    }
}

int IndexOf(int[] argumenty, int find) // теперь адаптируем решение предыдущей задачи 010, где мы находили позицию нужного нам элемента. определяем метод и Обзываем этот метод IndexOf, в данном случае он БУДЕТ возвращать позицию то есть индекс. в качестве аргумента будет приходить массив argumenty и какой-то элемент find. 
{
    int count = argumenty.Length;// определяем количество элементов в массиве
    int index = 0; // даём старт для счётчика от нуля индекса.
    int position = -1; // минус 1 присваиваем для того, когда в массиве нет числа которое мы ищем, выдавало сообщение -1, что можно интерпретировать как элемент не найден. Так как мы знаем что индекс начинается от 0, то -1 будет обозначать что такого элемента который мы ищем в массиве нет.
    while (index < count)
    {
        if(argumenty[index] == find) // в этом случае нам нужно куда-то сохранить позицию элемента в массиве, для этого нужна строка 29 int position = -1; и 34 position = index;.
        {
            position = index;
            break; 
        }
        index++;
    }
    return position;
}

int[] massiv = new int[10]; // команда означает: создай новый массив в котором будет 10 элементов

FillMassiv(massiv); // и даём команду заполнить массив
massiv[4] = 4;
massiv[6] = 4;
PrintMassiv(massiv); // и даём команду распечатать его
Console.WriteLine(); // вводим чтобы быть увереным что не является частью массива void

int pos = IndexOf(massiv, 4); // определяем переменную pos и в неё положим результат методы IndexOf. В качестве аргумента будет передаваться наш массив massiv и в качестве примера будем искать 4.
Console.WriteLine(pos); // после того как метод отработает на экране покажет позицию