double area (int r)
{
    return (Math.PI * (r*r));
}

double circumference (int r)
{
    return (2* Math.PI * (r*r));
}

Console.Write("area of 1 is {0}\narea of 3 is {1}\narea of 5 is {2}\n", area(1), area(3), area(5));
Console.Write("circumference of 1 is {0}\ncircumference of 3 is {1}\ncircumference of 5 is {2}\n", circumference(1), circumference(3), circumference(5));