using System;

namespace operaciones
{
    public class Suma
    {


        public Suma()
        {

        }
        public Suma(double n1, double n2)
        {
            this.Num1 = n1;
            this.Num1 = n2;
        }

        public double Num2 { get; private set; }
        public double Num1 { get; private set; }
        
        public double Sumar ()
        {
            return this.Num1 + this.Num2;
        }
    }
}
