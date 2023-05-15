using System;

class WaterTankProgram
{
    static void Main()
    {
        Console.WriteLine("Enter the capacity of the water tank: ");
        double tankCapacity = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the average volume of water consumed during each break: ");
        double averageVolumePerBreak = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the volume of water that can be added in each water refill cycle: ");
        double refillVolume = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the interval between rest periods: ");
        int restPeriodInterval = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the interval between water refill cycles: ");
        int refillCycleInterval = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the total duration of the activity: ");
        int totalDuration = Convert.ToInt32(Console.ReadLine());

        // Calculate the number of rest periods
        int numberOfRestPeriods = totalDuration / restPeriodInterval;

        // Calculate the number of water refill cycles
        int numberOfRefillCycles = totalDuration / refillCycleInterval;

        // Calculate the remaining water after each rest period and refill cycle
        double remainingWater = tankCapacity;
        for (int i = 1; i <= numberOfRestPeriods; i++)
        {
            remainingWater -= averageVolumePerBreak;
            if (remainingWater < 0)
            {
                Console.WriteLine("Not Enough Water");
                return;
            }

            if (i % refillCycleInterval == 0)
            {
                remainingWater += refillVolume;
                if (remainingWater > tankCapacity)
                {
                    Console.WriteLine("Overflow Water");
                    return;
                }
            }
        }

        Console.WriteLine("Enough Water, Remaining: " + remainingWater);
        if (numberOfRestPeriods % refillCycleInterval == 0)
        {
            Console.WriteLine("Overflow Water");
        }
    }
}
