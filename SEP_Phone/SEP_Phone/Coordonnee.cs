using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_Phone
{
    class Coordonnee
    {
        private double x;
        private double y;
        private double z;

        public Coordonnee(double x, double y,double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double getX()
        {
            return this.x;
        }
        public void setX(double x)
        {
             this.x = x;
        }
    }
}
