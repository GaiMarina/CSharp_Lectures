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
