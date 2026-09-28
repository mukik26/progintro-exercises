int iterationer = 10;
int[] array = {1, 2, 3, 4, 5};

// increment
try {
    for (int i=0 ; i<iterationer ; i++) {
        array[i]++;
    }
} catch (IndexOutOfRangeException e){
   Console.WriteLine("Exception Caught! The index was outside the bounds of the array");
   Console.WriteLine(e); // print out the whole error variable
}

// print
for (int i=0 ; i<array.Length ; i++) {
    Console.WriteLine(array[i]);
}
