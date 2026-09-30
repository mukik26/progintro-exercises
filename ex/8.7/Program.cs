double discriminant (double a, double b, double c){
    return (b * b) - 4 * a * c;
}

double[] roots (double a, double b, double c){
    
    double d = discriminant(a, b, c); 
    
    double root1 = (-b + Math.Sqrt(d)) / (2*a);
    double root2 = (-b - Math.Sqrt(d)) / (2*a);
    
    return new double[] {root1, root2};
    }

Console.WriteLine(discriminant(2.0, 5.0, -3.0)); // should return 49

double[] array = roots(2.0, 5.0, -3.0);
for (int i = 0; i <array.Length; i++){
    Console.Write(array[i]+" "); 
}