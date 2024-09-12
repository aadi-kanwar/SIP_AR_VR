// Code to perform basic arithmetic operations using C#.
// 12.09.2024
using System; 
public class Calci 
{ 
    public static void Main() 
    { 
        int a; 
        a = 10; 
        Console.WriteLine("First Number: {0}", a); 
        double fnum = 14.40, snum = 4.60, result; 
        int num1 = 26, num2 = 4, rem; 
        // Addition 
        result = fnum + snum; 
        Console.WriteLine("{0} + {1} = {2}", fnum, snum, result); 

        // Subtraction 
        result = fnum - snum; 
        Console.WriteLine("{0} - {1} = {2}", fnum, snum, result); 

        //Multiplication 
        result = fnum * snum; 
        Console.WriteLine("{0} * {1} = {2}", fnum, snum, result); 

        // Division 
        result = fnum / snum; 
        Console.WriteLine("{0} / {1} = {2}", fnum, snum, result); 

        // Modulo 
        result = fnum % snum; 
        Console.WriteLine("{0} % {1} = {2}", fnum, snum, result);
    } 

} 