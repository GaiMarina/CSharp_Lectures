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
 /*
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
*/
//=======================
/*
// 4. Перебор слов.
//    Есть машинный алфавит из 4-х букв. Показать все слова из этих букв.

char[] s = { 'а', 'и', 'с', 'в'};

int count = s.Length;

int n = 1;

for(int i = 0; i < count; i++) //однобуквенные слова
    Console.WriteLine($"{n++, -5}{s[i]}");
*/
// двубуквенные слова
/*
char[] s = { 'а', 'и', 'с', 'в'};

int count = s.Length;

int n = 1;

for(int i = 0; i < count; i++)
    for(int j = 0; j <  count; j++)
    Console.WriteLine($"{n++, -5}{s[i]}{s[j]}");
*/
//=====================
/*
//рекурсия. Общее решение.

int n = 1;

void FindWords(string alphabet, char[] word, int length = 0)
{
    if(length == word.Length)
    {
       Console.WriteLine($"{n++} {new String(word)}"); return;
    }
 
    for(int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
FindWords("аисв", new char[5]);
*/
//======================
/*
//Алгоритм обхода директории. (посмотреть все папки и файли в директории)
//Как получить доступ к нужной директории.
//3 строчки ниже - получение даты и времени создания папки по ссылке на нее.
string path = "/home/marina/Documents/GeekBrains/GBLectures/CSharp_Lectures/Example001_HelloConsole";
DirectoryInfo di = new DirectoryInfo(path); //+ cв-во папки, кот.посмотреть//Класс работы с директориями.
System.Console.WriteLine(di.CreationTime);
//Смотрим какие внутри содержатся файлы.
FileInfo[] fi = di.GetFiles();

for(int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}
*/
//====================================
/*
//РУКУРСИЯ для изучения содержимого папок.

void CatalogInfo(string path, string indent = "") //исскуственный прием: отступы, чтобы видеть
{                                                 // структуру папки.
    DirectoryInfo catalog = new DirectoryInfo(path);
    DirectoryInfo[] catalogs = catalog.GetDirectories();

    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }
    FileInfo[] files = catalog.GetFiles();
    for(int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}
string path = @"/home/marina/Documents/GeekBrains/GBLectures/CSharp_Lectures";
CatalogInfo(path);
*/
//==============================
/*
//Пирамидки.

void Towers(string with = "1", string on = "3", string some = "2", int count = 4)
{
if (count > 1) Towers(with, some, on, count - 1);
Console.WriteLine($"{with} >> {on}");
if (count > 1) Towers(some, on, with, count - 1);
}

Towers();
*/
//=========================
/*
//Обход разных структур.

// ((4 - 2) * (1 + 3)) / 10
// Получить все значения узлов, которые содержит дерево.

string emp = string.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
//                 0    1    2     3    4    5    6    7    8    9    10   11
void InOrderTraversal(int pos = 1) //аргумент - начальная позиция, с кот.будет обход.
{
    if (pos < tree.Length) //если позиция вышла за количество элементов дерева, рекурсия закончена.
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
    if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.Write(tree[pos]);
    if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
}

InOrderTraversal();
*/
//=======================

decimal fRec = 0;
decimal fIte = 0;

decimal FibonacciRecursion(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
}

decimal FibonacciIteration(int n)
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for(int i = 2; i <= n; i++)
    {
        result = f0 + f1;

        f0 = f1;
        f1 = result;
        fIte++;
    }
    return result;
}

Console.ReadLine();
DateTime dt = DateTime.Now;//будем сравнивать два подхода

for(int n = 10; n <  15; n++)
{
    Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fIte = {fIte.ToString("### ### ###"), -15}");
    fIte = 0;
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

Console.WriteLine();
Console.ReadLine();

dt = DateTime.Now;
for(int n = 10; n <  15; n++)
{
    Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} fRec = {fRec.ToString("### ### ###"), -15}");
    fRec = 0;
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

Console.ReadLine();

//==========================
/*
//квадратик

int[,] pic = new int[1000, 1000];
for (int i = 0; i < 1000; i++)
{
pic[0, i] = 1;
pic[i, 0] = 1;
pic[i, 999] = 1;
pic[999, i] = 1;
}
*/