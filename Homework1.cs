﻿namespace HelloWorld;
class Program
{
    static void Main(string[] args)
    {
       double x = 2.5;
       double y = 3.3;
       double z = 4*x*x+3*y;
       Console.WriteLine($"x = {x}; y = {y}");
       Console.WriteLine($"The value of z is: {z}");
    }
}
