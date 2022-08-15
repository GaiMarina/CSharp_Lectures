using System.Linq;

var a = 12; // неявная типизация. 
var b; //не запустится, не знает сколько памяти выделить на переменную.

Console.WriteLine(a.GetType()); //консоль прописывает тип данных


var data = new int[]{1,2,3,4}
        .Where(e => e > 0)
        .Select(e => new {q = e, w = e + 1});
Console.WriteLine(data.GetType());
