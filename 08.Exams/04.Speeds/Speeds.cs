using System;

/// <summary>
/// You are given a sequence of the speeds of cars in a single-lane-street. 
/// A car can catch up to the car B, only if B is in-front of A and the speed of A is greater than the 
/// speed of B, and then the speed of A is lowered to the speed of B. Each gathering of cars is called a group.
/// You task is to find the sum of the initial speeds of the longest group of cars (the group with most 
/// cars in it). If more than one group with equal length exists, then find the biggest sum of the initial 
/// speeds of these groups.
/// </summary>
class Speeds
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int cars = int.Parse(Console.ReadLine());      
        int group = 0;
        int bestGroup = 0;
        int sum = 0;
        int bestSum = 0;
        int lowSpeed = 0;

        for (int i = 0; i < cars; i++)
        {
            int speed = int.Parse(Console.ReadLine());

            if (speed > lowSpeed)
            {
                group++;
                if (lowSpeed == 0)
                {
                    lowSpeed = speed;
                }                             
                sum = sum + speed;
                if (group > bestGroup)
                {                   
                        bestGroup = group;
                        bestSum = sum;                              
                }
                else if (group == bestGroup)
                {
                    if (sum > bestSum)
                    {
                        bestGroup = group;
                        bestSum = sum;
                    }
                }
            }
            else if(speed < lowSpeed)
            {
                lowSpeed = speed;
                group = 0;
                sum = lowSpeed;
            }
            else
            {
                group = 1;
                sum = speed;
            }
        }      
        Console.WriteLine(bestSum);
    }
}