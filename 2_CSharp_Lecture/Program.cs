﻿/*
// Найти максимум из 9 чисел.
// "Стихийный подход"

int a1 = 15;
int b1 = 2311;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 313;

int max = a1;
if(b1 > max) max = b1;
if(c1 > max) max = c1;

if(a2 > max) max = a2;
if(b2 > max) max = b2;
if(c2 > max) max = c2;

if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;

Console.WriteLine(max);
*/
/*
// Найти максимум из 9 чисел.
// Используя метод.

int Max(int arg1, int arg2, int arg3) // Сравним по 3 числа.
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    return result;
}

int a1 = 15;
int b1 = 2311;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 313;

int max1 = Max(a1, b1, c1);
int max2= Max(a2,b2, c2);
int max3 = Max(a3,b3, c3);
int max = Max(max1, max2, max3);

Console.WriteLine(max);

*/

/*
// Найти максимум из 9 чисел.
// Функция внутри аргумента.

int Max(int arg1, int arg2, int arg3) // Сравним по 3 числа.
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 15567;
int b1 = 2311;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 313;

int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));

Console.WriteLine(max);
*/

// Найти максимум из 9 чисел.
// Избавляемся от большого количества переменных.

int Max(int arg1, int arg2, int arg3) // Сравним по 3 числа.
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
} 
//               0   1   2   3   4   5   6   7   8
int[] array = { 11, 251, 31, 41, 15, 61, 17, 18, 19 };
// array[0] = 12; //обращаемся к элементу массива и присваиваем ему значение
// Console.WriteLine(array[4]); //выводим соответствующее значение элемента по индексу

int max = Max( // вместо max можно result
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(max); // вместо max можно result