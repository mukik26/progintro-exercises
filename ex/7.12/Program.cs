// declare Normal and leap years
int[] monthsNormal = [31,28,31,30,31,30,31,31,30,31,30,31];
int[] monthsLeap = [31,29,31,30,31,30,31,31,30,31,30,31];

int[] pointer;

// iterates through year 2000 and 2020.
// If the year is divisible by 4 (leap year) it sets pointer to leap array
// Lastly, it prints the year and leap years.
for (int i = 2000 ; i <= 2020 ; i++){
    if (i % 4 == 0){
        pointer = monthsLeap;
    } else {
        pointer = monthsNormal;
    }
    Console.Write("\nDays of the months in year " + i + ": ");
    foreach (int num in pointer)
        Console.Write(num + " ");
}