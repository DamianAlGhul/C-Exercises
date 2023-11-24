double A;
double B;
double result;

Console.WriteLine("Calculate the area of a rectangle");

Console.WriteLine("\nEnter the value of 'A': ");
A = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the value of 'B': ");
B = Convert.ToDouble(Console.ReadLine());

result = A * B;
Console.WriteLine("\nSide A has a value of: " + A + "\nSide B has a value of: " + B + "\nThe result is: " + result);