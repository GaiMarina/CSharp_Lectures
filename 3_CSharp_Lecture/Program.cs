/*
// 1 тип. Ничего не принимают. Ничего не возвращают.
void Method1()
{
    Console.WriteLine("Автор ...");
}
//Как вызываются?
 Method1();
*/
/*
 // 2 тип. Ничего не возвращают, но могут принимать аргументы.
 void Method2(string msg)
 {
    Console.WriteLine(msg);
 }
 Method2("Текст сообщения");
*/
/*
 //Когда метод принимает несколько аргументов, аргументы могут быть именованные.

 void Method21(string msg, int count)
 {
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
 }
 Method21("Текст", 4); // Сколько раз хочу увидеть текст.
*/
/*
 //Мы можем явно указывать какому аргументу какое значение хотим присвоить.
 void Method21(string msg, int count)
 {
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
 }
 Method21(msg: "Текст", count: 4); // Сколько раз хочу увидеть текст.

 //Именованные аргументы не обязательно писать по порядку:
 // Method21(count: 4, msg: "новый текст");
*/
/*
 // 3.Тип. Что возвращают, но ничего не принимают.
 int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);
*/
/*
// 4.Тип. Что-то принимают, что-то возвращают.
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);
*/
/*
// FOR
for(int i = 0; i < 10; i++)
{
    Console.WriteLine(i)
}
*/
//Example.
/*
string Method4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }  
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);
*/
/*
//ЦИКЛ В ЦИКЛЕ.
for(int i = 0; i < 10; i++)
{
    for(int j = 0; j < 10; j++)
    {
        Console.WriteLine(i*j)
    }
    Console.WriteLine()
}
*/
/*
//Таблица умножения.
for(int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine(); //Для пустой строки после результатов по каждой цифре.
}
*/
/*
//====================
 // Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить большими "К", 
 // а большие "C" заменить маленькими "c".
 //19.30

 string text = "- Я думаю, - сказал князь, улыбаясь, - что, ежели бы вас послали вместо нашего милого "
             + "Винценгероде, вы бы взяли приступом согласие прусского короля."
             + "Вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty"
//             012
//s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
*/
//====================
// Упорядочивание данных внутри массива.
int[] arr ={1,5,4,3,2,6,7,1,1};
//Подпрограмма для вывода массива на экран.
// 1 вариант
void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
//Метод, кот.будет упорядочивать массив.
void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length; j++) //ищем нужный элемент.
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];  // переносим.
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
    
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);