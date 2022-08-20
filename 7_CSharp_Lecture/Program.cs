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
