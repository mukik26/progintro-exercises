float price = 599.95F;
int christmas_start = 30672000; // day 355
int christmas_end = 31104000; // day 360

int newyear;
//newyear = 21816000; // day 252
newyear = 30758400; // day 356


// checks whether the newyear seconds is between start of christmas and end of christmas
bool christmas = (newyear >= christmas_start && newyear <= christmas_end);

if (christmas == true) {
    float sale_price = price - (price * 0.30F); // calcuate 30% rebate
    Console.WriteLine("It's Christmas!\nThe price is: " + sale_price); // print the output
} else {
    Console.WriteLine("It's not Christmas\nThe price is: " + price);
}