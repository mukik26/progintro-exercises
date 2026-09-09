/*
Write a program that calculates and prints out the area (π · r 2 ) of three circles with radiuses of 1, 3 and 5.
*/

// declare radius and area
// instead of making 3 radius variables, we change the value when needed.
byte radius;
double area;

// first circle
radius = 1;
area = 3.14159 * radius * radius;
Console.WriteLine("The area of a circle with " + radius + " is " + area);

// second circle
radius = 3;
area = 3.14159 * radius * radius;
Console.WriteLine("The area of a circle with " + radius + " is " + area);

// third circle
radius = 5;
area = 3.14159 * radius * radius;
Console.WriteLine("The area of a circle with " + radius + " is " + area);