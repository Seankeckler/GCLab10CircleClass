using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GCLab10CirclesCircumference
{
    class Circle
    {
        private double Radius; 

        public Circle(double radius)
        {
            this.Radius = radius;
            
        }

        public double CalculateCircumference()
        {
            double pi = Math.PI;
            double circumference = 2 * pi * Radius;
            return circumference;
            
        }

        public string CalculateFormattedCircumference()
        {
            double circumference = CalculateCircumference();
            string formatedCircumference = FormatNumber(circumference);
            return formatedCircumference;
                
            
        }

        public double CalculateArea()
        {
            double pi = Math.PI;
            double area = pi * Radius * Radius;
            return area;
        }

        public string CalculateFormattedArea()
        {
            double Calculatearea = CalculateArea();
            string formatedArea = FormatNumber(Calculatearea);
            return formatedArea;
        }

        private string FormatNumber(double x)
        {

            x = Math.Truncate( x * 100) / 100;
            return x.ToString();
        }



    }
}
