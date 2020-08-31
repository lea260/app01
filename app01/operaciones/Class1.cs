using System;

namespace operaciones
{
    public class Suma
    {
        
        public double Num2 { get; private set; }
        public double Num1 { get; private set; }
        Suma(double n1, double n2)
        {
            this.Num1 = n1;
            this.Num1 = n2;
        }
        public double Sumar ()
        {
            return this.Num1 + this.Num2;
        }
    }
}
