using System;
namespace CarSimulator
{
    public class State
    {
        public double position;
        public double velocity;
        public double acceleration;
        public double time;

        //implement methods like set, constructors (if applicable)

        //default constructor, takes no params and sets state to 0 for all memeber variables
        public State()
        {
            this.position = 0;
            this.velocity = 0;
            this.acceleration = 0;
            this.time = 0;
        }
        //overloaded constructor which allows the intialization of state with actual values
        public State(double p, double v, double a, double t)
        {
            this.position = p;
            this.velocity = v;
            this.acceleration = a;
            this.time = t;
        }

        public void set(double p, double v, double a, double t)
        {
            this.position = p;
            this.velocity = v;
            this.acceleration = a;
            this.time = t;
            return;
        }


    }
}
