﻿Console.WriteLine("Hello, we gonna see what logic operators exist: ");

bool value1 = true;
bool value2 = false;
bool value3 = true;

Console.WriteLine("\n&&: Is 'y' or 'and'");
Console.WriteLine("\n||: Is 'o' or 'or'");
Console.WriteLine("\n!: Is 'no' or 'not'");
Console.WriteLine("\n^: Is 'xor'");

bool resultAnd = value1 && value2 && value3;
Console.WriteLine(resultAnd);

bool resultOr = value1 || value2 || value3;
Console.WriteLine(resultOr);

bool resultAndOr = (value1 && value2) || value3;
Console.WriteLine(resultAndOr);