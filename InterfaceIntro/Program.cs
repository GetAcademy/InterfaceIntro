using InterfaceIntro;
using InterfaceIntro.Enumers;

EnumerDemo.Run();
return;
var a = new CenteredHeader("Overskrift 1");
var b = new IndentedParagraph("Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. ");
var c = new IndentedParagraph("Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. ");
var d = new CenteredHeader("Overskrift 2");
var e = new IndentedParagraph("Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. ");

var f1 = new BulletPoint("a");
var f2 = new BulletPoint("b");
var f3 = new BulletPoint("c");
//a.Show();
//b.Show();
//c.Show();
//d.Show();
//e.Show();
//f1.Show();
//f2.Show();
//f3.Show();

var textElements = new ITextElement[] { a, b, c, d, e, f1, f2, f3 };
foreach (var textElement in textElements)
{
    textElement.Show();
}

Console.ReadKey();

Console.Clear();
foreach (var textElement in textElements)
{
    textElement.ShowHighlighted();
}


/*
 * Litt mer om testing
 * Intro interface
 *  - ev. IEnumerable og IEnumerator
 * Ev. litt om LINQ
 *  - FirstOrDefault, FirstOrDefault, Where, Select, ToArray, ToList
 *  - basert på interface
 *  - extension methods
 *  - builder pattern
 */