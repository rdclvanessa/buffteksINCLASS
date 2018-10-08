using System;

namespace InterestCalcFINAL
{
	class Program
	{
		static void Main(string[] args)
		{
			float rate = 0.0F;

			//Accepts user credit score as args 0
			if (Convert.ToInt32(args[0]) >= 300 && Convert.ToInt32(args[0]) <= 579) { rate = 0.26F; }
			else if (Convert.ToInt32(args[0]) >= 580 && Convert.ToInt32(args[0]) <= 669) { rate = 0.24F; }
			else if (Convert.ToInt32(args[0]) >= 670 && Convert.ToInt32(args[0]) <= 739) { rate = 0.22F; }
			else if (Convert.ToInt32(args[0]) >= 740 && Convert.ToInt32(args[0]) <= 799) { rate = 0.20F; }
			else if (Convert.ToInt32(args[0]) >= 800 && Convert.ToInt32(args[0]) <= 850) { rate = 0.18F; }

			//Accepts user age as args 1
            if (Convert.ToInt32(args[1]) >= 18 && Convert.ToInt32(args[1]) <= 29) { rate = rate + 0.006F; }
            else if (Convert.ToInt32(args[1]) >= 30 && Convert.ToInt32(args[1]) <= 64) { rate = rate + 0.004F; }
            else if (Convert.ToInt32(args[1]) >= 65 && Convert.ToInt32(args[1]) <= 110) { rate = rate + 0.002F; }

            //Accepts user gender as args 2
            if (Convert.ToChar(args[2]) == 'M' ) { rate = rate + .005F; }

            //Principle is args 3
            //Years is args 4
            //Number of time is args 5
            double amount = Convert.ToDouble(args[3]) * (Math.Pow(1.0 + ((double)rate / Convert.ToDouble(args[5])), (Convert.ToDouble(args[5]) * Convert.ToDouble(args[4]))));

            Console.WriteLine(amount);

            
        }
	}
}
