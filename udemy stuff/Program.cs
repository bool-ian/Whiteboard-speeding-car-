using System;

namespace udemy_stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that asks the user to enter the speed limit.
            Once set, the program asks for the speed of a car.If the user enters a value less than the
            speed limit, program should display Ok on the console.If the value is above the speed limit, 
            the program should calculate the number of demerit points.For every 5mph above the speed limit,
            1 demerit points should be incurred and displayed on the console.If the number of demerit points
            is above 12, the program should display License Suspended.*/
            Speeding();
        }

        static void Speeding()
        {
            Console.WriteLine("Enter the speed limit");
            int speedLimit = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the speed of the car");
            int carSpeed = int.Parse(Console.ReadLine());
            

            if(carSpeed < speedLimit)
            {
                Console.WriteLine("Speed is OK");
            }
            else if(carSpeed > speedLimit)
            {
                int demeritpoints = (carSpeed - speedLimit)/5;

                if(demeritpoints > 12)
                    Console.WriteLine("License Suspended");
                else
                    Console.WriteLine($"Slow Down, you have {demeritpoints} points");
                
            }


        }

    }
}
