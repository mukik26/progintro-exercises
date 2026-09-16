// hardcoded/explicit array
int[] array = [5215, 92515, 272, 927, 992, 1, 3592, 956, 4, 87654, 23, 5678, 2356];
Console.WriteLine(array.Length);

// This variable is the start of parsing through the array.
int max = array[0];

// Iterates/parses through the array and compares i with the starting point
// If the array[i] is bigger then the starting array is reassigned to array[i]
// And repeat until we have gone through array.length
for (int i = 1; i < array.Length; i++) {
    if (array[i] > max)
    {
        max = array[i];
    }
}

// prints the index of the largest number
Console.WriteLine(" The largest number in array is: "+max);