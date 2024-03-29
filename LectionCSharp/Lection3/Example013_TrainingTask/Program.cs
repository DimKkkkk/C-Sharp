﻿/* Задача
Дан текст. В нём нужно все пробелы заменить чёрточками, маленькие буквы «к»
заменить большими «К», а большие «С» заменить на маленькие «с» */

string text = "— Я думаю, — Сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // r

string Replace(string text, char oldValue, char newValue) // string text - берём текст, char oldValue - берём символ из текста, char newValue - меняем на новый символ
{
    string result = String.Empty; // чтобы не путать себя заводим новую строку result и даём ему пустое значение

    int length = text.Length; // для того чтобы определить длину нашего текста обращаемся к свойству показывающий количество символов текста text.Length.
    for (int i = 0; i < length; i++) // при помощи цикла for пробегаемся по всем символам текста от нулевого i=0. и ставим условие пока i меньше длины текста
    {
        if (text[i] == oldValue) result = result + $"{newValue}"; // если текущий символ text[i] совпал с тем символом который мы хотим заменить oldValue, то в результат мы кладём новый символ newValue
        else result = result + $"{text[i]}"; // иначе если совпадений не обнаружено то в наш result добавить текущий символ какой у нас был
    }
    return result; // возвращаем результат
}

string newText = Replace(text, ' ', '|'); // присваиваем новый текст с присвоением метода Replace где в скобках указываем что на что надо заменить, в нашем случае пробелы на черточки
Console.WriteLine(newText); // вывод нового текста
Console.WriteLine(); // вводим чтобы был отступ от текста первого
newText = Replace(newText, 'к', 'К'); // в новом тексте делаем замену уже букв к на К
Console.WriteLine(newText); // выводим ещё раз новый текст
Console.WriteLine();
newText = Replace(newText, 'С', 'с'); 
Console.WriteLine(newText);