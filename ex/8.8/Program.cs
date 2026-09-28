int fac (int n)
{
    if( n == 0){
        return 1;
    } else
    return n * fac(n-1); 
}
Console.WriteLine(fac(4));