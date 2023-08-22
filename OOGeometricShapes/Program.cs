using OOGeometricShapes;
using System.Drawing;

var square1 = new Square(4);
Console.Write("1. ");
Console.WriteLine(square1.Perimeter(2, 2, 3, 4));
Console.WriteLine(square1.Side1);
Console.Write("2. ");
Console.WriteLine(square1.Area(67));

var rect1 = new Rects(4, 5);
Console.Write("3. ");
Console.WriteLine(rect1.Perimeter(4,5,2,3));

Console.Write("4. ");
Console.WriteLine(rect1.Area(4,4));

var quad1 = new Quads(1,2,3,4);
Console.Write("5. ");
Console.WriteLine(quad1.Perimeter(6,7,8,9));