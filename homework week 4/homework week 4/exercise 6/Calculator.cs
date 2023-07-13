using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Create a class Calculator with the following methods:

- Add(int x, int y) - returns the sum of x and y.
- Subtract(int x, int y) - returns the difference between x and y.
- Multiply(int x, int y) - returns the product of x and y.
- Divide(int x, int y) - returns the quotient of x and y.
- Power(double x, double y) - returns x raised to the power of y.
- SquareRoot(double x) - returns the square root of x.

The following program should work after you implement missing classes:

Calculator calculator = new Calculator();

Console.WriteLine(calculator.Add(2, 3)); // Outputs 5
Console.WriteLine(calculator.Subtract(5, 2)); // Outputs 3
Console.WriteLine(calculator.Multiply(3, 4)); // Outputs 12
Console.WriteLine(calculator.Divide(10, 5)); // Outputs 2
Console.WriteLine(calculator.Power(2, 3)); // Outputs 8
Console.WriteLine(calculator.SquareRoot(9)); // Outputs 3*/


namespace homework_week_4.exercise_6
{
    public class Calculator
    {
        public Calculator() 
        { }
        public double x;
        public double y;
        public int Add(int x, int y) 
        { return x + y;}
        public int Subtract(int x, int y)
        { return x - y; }
        public int Multiply(int x, int y)
        { return x * y; }
        public int Divide(int x, int y)
        { return x / y; }
        public double Power(double x, double y)
        { return Math.Pow(x,y); }
        public double SquareRoot(double x)
        { return Math.Sqrt(x); }

    }
}
