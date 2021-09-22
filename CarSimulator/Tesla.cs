using System;
namespace CarSimulator
{
    public class Tesla : Car
    {
        public Tesla() : base()
        {
        }
        public Tesla(string model, double mass, double engineForce, double drag) : base(model, mass, engineForce, drag)
        {

        }
    }
}
