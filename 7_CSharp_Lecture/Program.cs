/*
// 1. Собрать строку с числами от a до b, a <= b.

string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for(int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

// То же самое рекурсия.

string NumbersRec(int a, int b)
{
    if(a <= b) return $"{a} " + NumbersRec(a + 1, b);
        else return string.Empty;
}

Console.WriteLine(NumbersFor(1,10)); //10 входит.
Console.WriteLine(NumbersRec(1,10)); //10 входит.
*/
//=========================
/*
// 1 задача в обратном порядке.
// 1. Собрать строку с числами от a до b, a >= b.

string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for(int i = b; i >= a; i--)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec(int a, int b)
{
    if(a <= b) return NumbersRec(a + 1, b) + $"{a} "; //Заполняем строку справа.
        else return string.Empty;
}

Console.WriteLine(NumbersFor(1,10)); //10 входит.
Console.WriteLine(NumbersRec(1,10)); //10 входит.

 //=====================

 // 2. Сумма чисел от 1 до n.

int SumFor(int n)
{
    int result = 0;
    for(int i = 1; i <= n; i++) result += i;
    return result;
}

int SumRec(int n)
{
    if(n == 0) return 0; //возвращаем нейтральный для сложения элемент.
    else return n + SumRec(n - 1);
}

Console.WriteLine(SumFor(10)); //55
Console.WriteLine(SumRec(10)); //55
*/
//===================
/*
//Факториал числа: произведение от 1 до n.

int FactorialFor(int n)
{
    int result = 1;
    for(int i = 1; i <= n; i++) result *= i;
    return result;
}

int FactorialRec(int n)
{
    if(n == 1) return 1; //обязательное условие выхода. 0! = 1 - тоже лучше описать.
    else return n * FactorialRec(n - 1);
}

Console.WriteLine(FactorialFor(10)); //3628800
Console.WriteLine(FactorialRec(10)); //3628800
*/
//=========================
 
// 3. Вычислить a в степени n.(степень - натуральное число)

int PowerFor(int a, int n)
{
    int result = 1;
    for(int i = 1; i <= n; i++) result *= a;
    return result;
}

int PowerRec(int a, int n)
{//0 в степени 0 рассмотреть отдельно.
//тернарный оператор: все решение 1-й строчкой:
    return n == 0 ? 1 : PowerRec(a, n - 1) * a;
    //if(n == 0) return 1; //обязательное условие выхода.
    //else return PowerRec(a, n - 1) * a;
}

// Упрощение с мат.формулами.

int PowerRecMath(int a, int n)
{
    if(n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}

Console.WriteLine(PowerFor(2,10)); //1024
Console.WriteLine(PowerRec(2,10)); //1024
Console.WriteLine(PowerRecMath(2,10)); //1024