using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_and_Interface
{
    class Circle
    {
        protected double radius;
        private string colour;

        public Circle(double r, string c)
        {
            this.radius = r;
            this.colour = c;
        }

        public Circle(double r) 
        { 
            this.radius = r;
        }
        public virtual double GetArea()
        {
            return Math.PI * Math.Pow(this.radius, 2);
        }
    }
}
