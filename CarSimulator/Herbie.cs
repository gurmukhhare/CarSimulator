using System;
namespace CarSimulator
{
    public class Herbie : Car
    {
        public Herbie() : base()
        {
        }
        public Herbie(string model, double mass, double engineForce, double drag) : base(model, mass, engineForce, drag)
        {
            //setting the protected air density variable in parent Car class
            airDensity = 0.5678; //Herbie defies laws of physics by having a lower air density (actual density for other Cars is 1.225)
        }

    }
}
