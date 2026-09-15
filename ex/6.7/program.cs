double tempc = 40;
double tempf;

while (tempc >= -5) {
    tempf = 32 + (9.0 / 5.0 * tempc);
    Console.WriteLine("C: " + tempc + "   F: " + tempf);
    tempc -= 0.5;
}