using System;

namespace nDeath.Challenge_1.Models
{
    public class Coordinate
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Coordinate(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static double CoordinateXo(double b, double a)
        {
            return -b / (2 * a);
        }

        public static double CoordinateY(double x, double a, double b, double c)
        {

            return a * Math.Pow(x, 2) + b * x + c;
        }
    }
}