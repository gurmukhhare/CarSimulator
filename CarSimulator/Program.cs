using System;

namespace CarSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the mass of the car (kg): ");
            double mass;
            mass = Convert.ToDouble(Console.ReadLine());

            // read in engine force
            Console.WriteLine("Enter the net force of the engine (N): ");
            double engine_force;
            engine_force = Convert.ToDouble(Console.ReadLine());

            // read in drag area coefficient multiplied with the drag area
            Console.WriteLine("Enter the car's drag area (m^2) multiplied by drag coefficient: ");
            double drag;
            drag = Convert.ToDouble(Console.ReadLine());

            // read in time step
            Console.WriteLine("Enter the simulation time step (s): ");
            double dt;
            dt = Convert.ToDouble(Console.ReadLine());

            // read in total number of simulation steps
            Console.WriteLine("Enter the number of time steps (int): ");
            int N;
            N = Convert.ToInt32(Console.ReadLine());

            // initialize the car's state
            double x0 = 0;  // initial position
            double v = 0;  // initial velocity
            double t = 0;  // initial time
            double fd = 0;
            double x1 = 0;
            double a = Physics1D.compute_acceleration(engine_force, mass); //calculating acceleration using the mass and engine force inputted
            double airDensity = 1.225; //air density constant to be used in calculations


            // run the simulation
            for (int i = 0; i < N; ++i)
            {
                t += dt;
                //a = Physics1D.compute_acceleration(v, t - dt, Physics1D.compute_velocity(v, a, t), t);
                v = Physics1D.compute_velocity(v, a, t);
                x1 = Physics1D.compute_position(x0, v, t);
                x0 = x1;
                fd = airDensity * v * v * 0.5 * drag;
                a = Physics1D.compute_acceleration(engine_force - fd, mass);

                // print the time and current state
                Console.WriteLine("t:{0}, a:{1}, v:{2}, x1:{3}, fd:{4} ", t, a, v, x1, fd);

            }
            State newState = new State(10, 20, 30, 40);
            Console.WriteLine("a:{0},v:{1}", newState.acceleration, newState.velocity);
            newState.set(99, 99, 99, 99);
            Console.WriteLine("a:{0},v:{1}", newState.acceleration, newState.velocity);

        }
    }
}
