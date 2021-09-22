using System;
using System.Linq;
using System.Collections.Generic;
namespace CarSimulator
{
    public class Highway
    {
        static void Main(string[] args)
        {
            int fleetNumberPerType = 25;

            //could also implement a fleet by using these lists and driving each type of car separately
            Tesla[] myTeslas = new Tesla[fleetNumberPerType].Select(myTesla => new Tesla("Tesla", 1500, 1000, 0.51)).ToArray();
            Prius[] myPriuses = new Prius[fleetNumberPerType].Select(myPrius => new Prius("Prius", 1000, 750, 0.43)).ToArray();
            Mazda[] myMazdas = new Mazda[fleetNumberPerType].Select(myMazda => new Mazda("Mazda", 1200, 500, 0.31)).ToArray();
            Herbie[] myHerbies = new Tesla[fleetNumberPerType].Select(myHerbie => new Herbie("Herbie", 2500, 3000, 0.45)).ToArray();

            var myCars = new List<Car>();
            for (int i = 0; i < fleetNumberPerType; i++)
            {
                // TODO: COMPUTE UPDATED STATE HERE
                myCars.Add(new CarSimulator.Tesla("Tesla", 1500, 1000, 0.51));
                myCars.Add(new CarSimulator.Prius("Prius", 1000, 750, 0.43));
                myCars.Add(new CarSimulator.Mazda("Mazda", 1200, 500, 0.31));
                myCars.Add(new CarSimulator.Herbie("Herbie", 2500, 3000, 0.45));


            }
            int counter = 0; //counter just to confirm output corresponds with cars in the fleet
            // loop through the time and list to drive all the vehicles
            for (double t = 0; t < 60; t += 10)
            {
                for (int i = 0; i < 4*fleetNumberPerType; i++)
                {
                    // TO DO: Drive myCars list and Display the cars states acceleration, speed, position, etc
                    myCars[i].drive(t);
                    Console.WriteLine("car: {3}, acceleration: {0}, speed: {1}, position: {2}", myCars[i].getState().acceleration, myCars[i].getState().velocity, myCars[i].getState().position,myCars[i].getModel());
                    counter++;

                }
            }

            Console.WriteLine(counter);


        }

    }
}
