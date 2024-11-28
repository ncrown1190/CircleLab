using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleLab
{
    internal class Circle
    {
        // Properties
        private double Radius { get; set; }

        //  Constructor
        public Circle(double radius)
        {
            Radius = radius;
        }

        public void GetPositiveNumber(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Invalid data. Please try again");
            }
            Radius = radius;
        }

        //  Methods
        // 01 to calculate Diameter
        public double CalculateDiameter()
        {
            return Radius * 2;
        }
        // 02 to calculate circumference
        public double CalculateCircumference()
        {
            double result = Math.PI * Radius * 2;
            result = Math.Round(result, 2);
            return result;
        }

        // 03 to calculate Area
        public double CalculateArea()
        {
            double result = Math.Round(Math.PI * (Radius * Radius), 2);
            return result;
            //return Math.PI * Math.Pow(Radius, 2); 
        }

        //  The grow method will adjust radius to double its value.
        public void Grow()
        {
            Radius *= 2;
        }

        public double GetRadius()
        {
            return Radius;
        }
    }
}
