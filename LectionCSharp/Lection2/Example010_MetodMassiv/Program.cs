﻿int[] massiv = {1, 2, 3, 7, 4, 5, 6, 7, 8}; // определяем новый массив

int n = massiv.Length; // определяем информацию сколько элементов в массиве, длина массива
int find = 7; // нас просят чтобы пользователь ввёл число

int index = 0; //определяем начало счётчика в массиве. от 0 потому что в массиве первый элемент под индексом 0.

while (index < n)
{
    if(massiv[index] == find)  // если элемент массива совпадает с find
    {
        Console.WriteLine(index); // нам покажет под каким индексом находится запрошенное число в find пользователем
        break;
    }
    //index = index + 1; вносим наш счётчик
    index++;
}

// если в массиве будет два одинаковых элемента то нам покажет их индексы обоих. чтобы это исправить, так как нас просили найти первый попавшийся и остановиться, добавляем break;
