using System;
namespace CarSimulator
{
    public class DragRace
    {
        static void Main(string[] args)
        {

            Car myTesla = new Car("Tesla", 1500, 1000, 0.51);
            Car myPrius = new Car("Prius", 1000, 750, 0.43);
            string winner;

            
            // drive for 60 seconds with delta time of 1s
            double dt = 1;

            for (double t = 0; t < 60; t += dt)
            {
                // print the time and current state
                // print who is in lead
                myTesla.drive(t);
                myPrius.drive(t);
                Console.WriteLine("t:{0}", t);
                Console.WriteLine("Prius Position: {0}, Prius Velocity: {1}, Tesla Position: {2}, Tesla Velocity: {3} ", myPrius.getState().position,myPrius.getState().velocity, myTesla.getState().position, myTesla.getState().velocity);
                if(myTesla.getState().position > 402.3 || myPrius.getState().position > 402.3)
                {
                    break;
                }
            }
            if (myPrius.getState().position > myTesla.getState().position)
            {
                winner = "Prius";
            }
            else
            {
                winner = "Tesla";
            }
            Console.WriteLine("the winner is:");
            Console.WriteLine(winner);
        }
    }
}
