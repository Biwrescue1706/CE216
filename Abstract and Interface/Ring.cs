using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_and_Interface
{
    class Ring : Circle
    {
        private double innerRadiuse;
        public Ring(double r , double ir ,string c) : base(r)
        {
            this.innerRadiuse = ir;

        }
        public Ring(double r ,double ir) : base(r)
        {
            this.innerRadiuse = ir;
        }

        public override double GetArea()
        {
            double area1 = base.GetArea();
            base.radius = innerRadiuse;
            double area2 = base.GetArea();
            return area1 - area2;
        }
    }
}
