﻿using System;

class Program
{
    static void Main()
    {
        int contPrimos = 0;
        int Num = 1;
        int NumPrimo;

        while (contPrimos < 9) 
        {
            bool primo = true;

            for (int i = 2; i < Math.Sqrt(Num); i++)
            {
                if (Num % i == 0)
                {
                    primo = false;
                    break;
                }
            }
            if (primo)
            {
                NumPrimo = Num;
                contPrimos++;
                Console.WriteLine(NumPrimo);
            }
            Num++;
        }
    }
}