﻿// Напишите прогу которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа
// 456 -> 46
// 782 -> 72

Console.Clear();

int num = new Random().Next(100, 1000);
int a1 = num / 100;
int a3 = num % 10;

int result = (a1 * 10) + a3; // этим мы получаем целое число и выводим ЕГО в результат консоли

Console.WriteLine($"{num} -> {result}"); //Console.WriteLine($"{num} -> {a1} {a3}"); - а этот вариант без 11 строки и он выводит первое и второе значение. Тоже можно.