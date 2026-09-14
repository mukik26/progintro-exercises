int month = 13;

// goes through each month number
// prints to console for the corresponding month (1-12)
// Fallbacks to invalid if month not found.
switch (month) {
    case 1: 
        Console.WriteLine("Hard Work!");
        break;
    case 2: 
        Console.WriteLine("Hard Work!");
        break;
    case 3: 
        Console.WriteLine("Hard Work!");
        break;
    case 4: // April 
        Console.WriteLine("Spring Holday - April");
        break;
    case 5: 
        Console.WriteLine("Hard Work!");
        break;
    case 6: 
        Console.WriteLine("Hard Work!");
        break;
    case 7: // july
        Console.WriteLine("Summer Holiday - July & August");
        break;
    case 8: // August
        Console.WriteLine("Summer Holiday - July & August");
        break;
    case 9: 
        Console.WriteLine("Hard Work!");
        break;
    case 10: //october
        Console.WriteLine("Autumn Holiday - October");
        break;
    case 11: 
        Console.WriteLine("Hard Work!");
        break;
    case 12: // December
        Console.WriteLine("Christmas Holiday - December");
        break;
    default:
        Console.WriteLine("invalid month");
        break;
}