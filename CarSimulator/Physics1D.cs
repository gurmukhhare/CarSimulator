using System;
namespace CarSimulator
{

    public class Physics1D
    {
        public static double compute_position(double x0, double v, double dt)
        {
            double position = x0 + (v * dt);
            return position;

        }
        public static double compute_velocity(double v0, double a, double dt)
        {
            double velocity = v0 + (a * dt);
            return velocity;
        }
        public static double compute_velocity(double x0, double t0, double x1, double t1)
        {
            double distanceChange = x1 - x0;
            double timeChange = t1 - t0;
            return distanceChange / timeChange;
        }
        public static double compute_acceleration(double v0, double t0, double v1, double t1)
        {
            double velocityChange = v1 - v0;
            double timeChange = t1 - t0;
            return velocityChange / timeChange;
        }
        public static double compute_acceleration(double f, double m)
        {
            return f / m;
        }


    }

}
