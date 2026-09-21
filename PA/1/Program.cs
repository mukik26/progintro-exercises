// explicit array
int[] array = [16, -78, -86, -97, -59, 19, -39, 55, -79, 9];

// variable that is used to compare values in array
int number = array[0];

// iterates through each array element
// increments i by 1 until i is larger than the array length.
for (int i = 1; i < array.Length; i++)
{
    // compares two elements to each other
    // assigns the smallest value to number
    if (number > array[i])
    {
        number = array[i];
    }
}
// prints the largest negative value
Console.WriteLine("The largest negative value stored in the array is: "+number);