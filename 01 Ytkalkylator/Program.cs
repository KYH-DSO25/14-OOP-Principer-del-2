/*
*   1.  Skapa den abstrakta klassen Shape med en abstrakt metod 
*       CalculateSurface() och fälten width och height. 
*           Skapa två nya klasser Triangle och Rectangle som implementerar den 
*           abstrakta metoden och returnerar figurens yta 
*           (height*width för rektangeln, height*width/2 för triangeln). 
*           
*           Skapa klassen Circle och en lämplig konstruktor så att height måste vara 
*           samma som width och implementera metoden CalculateSurface(). 
*           
*       Skriv sedan ett program som testar metoderna CalculateSurface() för 
*       de olika formerna (Rectangle, Triangle, Circle) sparade i en array.
*/

using _01_Ytkalkylator;

var figures = new Shape[]
{
    new Triangle(12.3, 4.56),
    new Rectangle(45.67, 8.9),
    new Circle(10)
};

foreach (var figure in figures)
{
    Console.WriteLine(figure);
}






Console.Write("\n\nTryck på en tangent för att stänga fönstret");
Console.ReadKey();