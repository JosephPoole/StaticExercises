using ConsoleApp1;
using System;

var celsius = TempConverter.FahrenheitToCelsius(50); 
var fahrenheit = TempConverter.CelsiusToFahrenheit(40); 

Console.WriteLine("After conversion:");
Console.WriteLine($"celcius {celsius}");
Console.WriteLine($"fahrenheit {fahrenheit}");
Console.WriteLine();
