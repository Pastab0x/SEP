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

        public Coordonnee()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
        }

        public Coordonnee(double x, double y,double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Coordonnee(Coordonnee coord)
        {
            this.x = coord.getX();
            this.y = coord.getY();
            this.z = coord.getZ();
        }

        public double getX()
        {
            return this.x;
        }

        public void setX(double x)
        {
             this.x = x;
        }

        public double getY()
        {
            return this.y;
        }

        public void setY(double y)
        {
            this.y = y;
        }

        public double getZ()
        {
            return this.z;
        }

        public void setZ(double z)
        {
            this.z = z;
        }

        public void decX(double amount)
        {
            this.x = this.x - amount;
        }

        public void addX(double amount)
        {
            this.x = this.x + amount;
        }

        public void decY(double amount)
        {
            this.y = this.y - amount;
        }

        public void addY(double amount)
        {
            this.y = this.y + amount;
        }

        public void decZ(double amount)
        {
            this.z = this.z - amount;
        }

        public void addZ(double amount)
        {
            this.z = this.z + amount;
        }
    }
}
