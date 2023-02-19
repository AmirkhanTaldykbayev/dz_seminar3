﻿/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

/*--------------------------------Первый-способ(топорный-с-использованием-магии-чисел)------------------------------------------
Console.WriteLine("Введите число: ");
string? number = Console.ReadLine();

int numLen = number.Length;

if (numLen == 5)
{
 if (number[0] == number[numLen - 1] && number[1] == number[numLen - 2])
        {
            Console.WriteLine($"Число {number} является палиндромом");
        }
        else
        {
            Console.WriteLine($"Число {number} не является палиндромом");
        }
}
else
{
    Console.WriteLine($"Число {number} не явлется пятизначным");
}
*/

//---------------------------------------------------Второй-способ-------------------------------------------------------------
// Для решения данной задачи я хотел сначала записать число как массив и сравнить каждый элемент массива с противоположным ему значением с конца
// Я пробовал сделать через цикл while, но ничего не получалось.

/*
while(i < numLen)
    if (number[i] == number[numLen - 1 - i])
        {
            Console.WriteLine($"Число {number} является палиндромом");
        }
    else
        {
            Console.WriteLine($"Число {number} не является палиндромом");
        }
    i++;
*/

// Как я понял проблема была в том, что после каждой проверки выводился либо первый текст, либо второй, и по окончанию выдавалось 
// несколько строк. После различных проверок и попыток изменить конструкцию, убедился что так метод не сработает.
/* Поэтому решил сделать все гораздо проще:
    1. Развернуть массив;
    2. Записать его в новую переменную;
    3. Сравнить массив введенных данных с его развернутым видом.
*/
// Теперь проблемой стало то, как именно развернуть массив в языке C#. Пришлось гуглить. Ответ нашелся довольно быстро.

Console.WriteLine("Введите число: ");
var number = Console.ReadLine();
int numLen = number.Length;

char []  numberReverse = number.ToCharArray(); //Забегая вперед, познакомился с типом данных "char".
Array.Reverse(numberReverse);                  // А вот и команда для разворота массива

if (number.Length == 5)
{
    if (number == new string(numberReverse))
    {
        Console.WriteLine($"Число {number} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {number} не является палиндромом");
    }
}
else
{
    Console.WriteLine($"Число {number} не явлется пятизначным");
}