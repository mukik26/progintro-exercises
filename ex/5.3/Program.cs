/*
Write a program that experimentally explores what happens when we add one to the highest value this type can represent.
*/

// byte experimentation
byte value = 255;
Console.WriteLine("The maximal unsigned byte value is "+ value);

value++;
Console.WriteLine("a +1 has been added to the byte. \n It is now: " + value);

// int experimentation
int intvalue = 2147483647;
Console.WriteLine("The maximal signed int value is "+ intvalue);

intvalue++;
Console.WriteLine("a +1 has been added to the int. \n It is now: " + intvalue);