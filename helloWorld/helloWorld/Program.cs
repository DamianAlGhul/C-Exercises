var sideA = 0d;
var sideB = 0d;
var result = 0d;

Console.WriteLine("Calculate the area of a rectangle");

Console.WriteLine("\nEnter the value of the side A: ");
sideA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\nEnter the value of the side B: ");
sideB = Convert.ToDouble(Console.ReadLine());

result = sideA * sideB;

Console.WriteLine("\nSide A: " + sideA + "\nSide B: " + sideB + "\nThe result is: " + result);