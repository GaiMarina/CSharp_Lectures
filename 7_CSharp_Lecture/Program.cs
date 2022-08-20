
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
Console.WriteLine(NumbersRec(1,10));