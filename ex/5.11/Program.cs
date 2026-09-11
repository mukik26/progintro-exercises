// agreed starting point is January 1st, 2000.
uint timestamp = 213321600; // 6 years and 279 days since the agreed starting point

// calculate the timestamp to years
uint year = timestamp / (86400*365);
uint days = (timestamp / 86400) % (365 * year);

// print the timestamp in year and days.
Console.WriteLine("year: " + year);
Console.WriteLine("days: " + days);