var radius = 0d;
var result = 0d;
const double Pi = 3.14;
Console.WriteLine("Welcome, let's calculate circles");

Console.WriteLine("Enter the radio value: ");

radius = Convert.ToDouble(Console.ReadLine());

result = Pi * (radius * radius);

Console.WriteLine("The area of circle is: " + result);