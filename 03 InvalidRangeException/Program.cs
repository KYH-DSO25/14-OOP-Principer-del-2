/*
*   3.  Skapa en klass InvalidRangeException<T> som innehåller information om 
*       ett feltillstånd relaterat till ett ogiltigt intervall. Den bör ha 
*       ett felmeddelande och visa intervallet [start … end].
*       
*       Skriv en enkel applikation som demonstrerar InvalidRangeException<int> och 
*       InvalidRangeException<DateTime> genom att mata in talen i 
*       intervallet [1 … 100] och datum i intervallet [1990-01-01 … 2030-12-31]
*/

try
{
	int begin = 1;
	int end = 100;

	int number = 150;

	if (begin < number && number > end)
		throw new InvalidRangeException<int>(begin, end);
}
catch (InvalidRangeException<int> ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Begin: {0}, End: {1}\n\n", ex.Begin, ex.End);
}

try
{
	DateTime begin = new DateTime(1980, 1, 1);
	DateTime end = new DateTime(2024, 12, 31);

	var date = new DateTime(2025, 10, 24);

	if(begin < date && date > end)
		throw new InvalidRangeException<DateTime>(begin, end);
}
catch (InvalidRangeException<DateTime> ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Begin: {0}, End: {1}", ex.Begin, ex.End);
}





Console.Write("\n\nTryck på en tangent för att stänga fönstret");
Console.ReadKey();