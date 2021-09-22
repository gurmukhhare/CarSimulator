using System;
namespace CarSimulator
{
    public class Car
    {
        private double mass;
        private string model;
        private double drag;
        private double engineForce;
        protected double airDensity = 1.225; //air density constant to be used in calculations, set to protected so it can be accessed from derived class
        public State myCarState;

        /// implement constructor and methods
        public Car(string model, double mass, double eForce, double drag)
        {
            //initializing member variables and state of every car instance
            this.myCarState = new State();
            this.mass = mass;
            this.model = model;
            this.drag = drag;
            this.engineForce = eForce;
        }

        public Car()
        {

        }

        //getter methods
        public string getModel()
        {
            return this.model;
        }
        public double getMass()
        {
            return this.mass;
        }

        public State getState()
        {
            return this.myCarState;
        }
        //implement inheritence

        public void drive(double dt)
        {
            //when car first starts driving and v=0, acceleration will be calculated using just engine force and mass since the drag force will be 0
            double acceleration = Physics1D.compute_acceleration(this.engineForce - (this.airDensity * this.myCarState.velocity * this.myCarState.velocity * 0.5 * this.drag), this.mass);
            double velocity = Physics1D.compute_velocity(this.myCarState.velocity, acceleration, dt);
            double position = Physics1D.compute_position(this.myCarState.position, velocity, dt);
            this.myCarState.set(position,velocity,acceleration,dt);
        }
        public void accelerate(bool on)
        {
            //not currently utilizing this method for anything (turns accelerator on/off)
        }


    }
}
