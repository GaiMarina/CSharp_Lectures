/* .
// 1. Ввести точки. Увеличить каждую (.) в два раза и показать пользователю ответ.

using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)";
                    
var data = text.Split(" ") //разбивка с учетом символа-разделителя.
                            //вместо var можно string[].

                    .ToArray(); //превращаем в массив.

for(int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
}
*/
//======================================
/*
// 2. Делим на пары без скобок. 

using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
                    .Replace("(", "") //избавляемся от скобок.
                    .Replace(")", "") //избавляемся от закрывающих скобок.
                    ;
Console.WriteLine(text);
var data = text.Split(" ") //разбивка с учетом символа-разделителя.

                .ToArray();

for(int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
} 
*/
//=======================================
/*
// 3. разбиваем каждый элемент и на его основе получаем массив из 2-х чисел: 
  // координата по x и по y.

using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
                    .Replace("(", "") //избавляемся от скобок.
                    .Replace(")", "") //избавляемся от закрывающих скобок.
                    ;
Console.WriteLine(text);

var data = text.Split(" ") //разбивка с учетом символа-разделителя.
                .Select(item => item.Split(',')) //получаем массив из массивов(из 2-х строк)
                .ToArray(); 

for(int i = 0; i < data.Length; i++)
{   
    // Console.WriteLine(data[i]);
    for(int k = 0; k < data[i].Length; k++)
    {   
        Console.WriteLine(data[i][k]); //обращение к элементу подмассива.
    }   
    Console.WriteLine();
} 
*/
//===============================
/*
// 4. Делаем еще одну выборку: текущий массив координат преобразуем в кортеж чисел.

using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
                    .Replace("(", "") //избавляемся от скобок.
                    .Replace(")", "") //избавляемся от закрывающих скобок.
                    ;
Console.WriteLine(text);

var data = text.Split(" ") //разбивка с учетом символа-разделителя (возьми текст, разбей)
                .Select(item => item.Split(',')) //получаем массив из массивов(из 2-х строк)
                .Select(e => (int.Parse(e[0]),int.Parse(e[1])))
                .ToArray();

for(int i = 0; i < data.Length; i++)
{   
    Console.WriteLine(data[i]);
    Console.WriteLine();
} 
*/
//===========================
/*
// 4. Получаем выборку, в которой первая координата увеличена в 10 раз.

using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
                    .Replace("(", "") //избавляемся от скобок.
                    .Replace(")", "") //избавляемся от закрывающих скобок.
                    ;
Console.WriteLine(text);

var data = text.Split(" ") //разбивка с учетом символа-разделителя.
                .Select(item => item.Split(',')) //получаем массив из массивов(из 2-х строк)
                .Select(e => (int.Parse(e[0]),int.Parse(e[1])))
                .ToArray();

for(int i = 0; i < data.Length; i++)
{   
    Console.WriteLine(data[i].Item1 * 10); //можно дописать .Item1 * 10 - 1-ю координату * на 10.
} 
*/
//=============================
/*
//5. Расписываем что такое Item1.

using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
                    .Replace("(", "") //избавляемся от скобок.
                    .Replace(")", "") //избавляемся от закрывающих скобок.
                    ;
Console.WriteLine(text);

var data = text.Split(" ") //разбивка с учетом символа-разделителя.
                .Select(item => item.Split(',')) //получаем массив из массивов(из 2-х строк)
                .Select(e => (x: int.Parse(e[0]),y: int.Parse(e[1])))
                .ToArray();

for(int i = 0; i < data.Length; i++)
{   
    Console.WriteLine(data[i].x * 10); //можно дописать .Item1 * 10 - 1-ю координату * на 10.
} 
*/
//=========================
/*
// 6.делаем увеличение координаты раз и на всегда.

using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
                    .Replace("(", "") //избавляемся от скобок.
                    .Replace(")", "") //избавляемся от закрывающих скобок.
                    ;
Console.WriteLine(text);

var data = text.Split(" ") //разбивка с учетом символа-разделителя.
                .Select(item => item.Split(',')) //получаем массив из массивов(из 2-х строк)
                .Select(e => (x: int.Parse(e[0]),y: int.Parse(e[1])))
                .Select(point => (point.x * 10, point.y)) //условную точку point превращаем во что-то новое.
                .ToArray();

for(int i = 0; i < data.Length; i++)
{   
    Console.WriteLine(data[i]); 
} 
*/
//=============================

//7. Производим выборку. Выводим пары, где первая координата будет четная и умноженная на 10.    

using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
                    .Replace("(", "") //избавляемся от скобок.
                    .Replace(")", "") //избавляемся от закрывающих скобок.
                    ;
Console.WriteLine(text);

var data = text.Split(" ") //разбивка с учетом символа-разделителя.
                .Select(item => item.Split(',')) //получаем массив из массивов(из 2-х строк)
                .Select(e => (x: int.Parse(e[0]),y: int.Parse(e[1])))
                .Where(e => e.x % 2 == 0) //Получаем только те точки, 
                // для кот.1-я координата-элемент кортежа - четная.
                .Select(point => (point.x * 10, point.y)) //условную точку point превращаем во что-то новое.
                .ToArray();

for(int i = 0; i < data.Length; i++)
{   
    Console.WriteLine(data[i]); 
} 

//кортеж - структура данных из переменных. (Могут быть разных типов)