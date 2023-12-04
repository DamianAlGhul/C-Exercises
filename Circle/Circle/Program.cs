var radius = 0d;
var area = 0d;
var area2 = 0d;
const double Pi = 3.14;

Console.WriteLine("Let's calculate the area of a circle");
Console.WriteLine("First, let the value of the radius: ");
radius = Convert.ToDouble(Console.ReadLine());

area = Math.PI * (radius * radius);
area2 = Pi * (radius * radius);

Console.WriteLine("\nThe radius of the circle is: " + radius + "\nThe area of the circle is: " + area);