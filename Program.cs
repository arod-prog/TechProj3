using System;

namespace TechProj3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user expected grade
            Console.WriteLine("Kilometer Increment Value");


            {
                string input = Console.ReadLine();

                decimal speed = decimal.Parse(input);
                double KM = 0.621371;

                if (10 <= speed && speed <= 25)
                {
                    Console.WriteLine("Kilometer" + " " + "Equiv Miles");
                    Console.WriteLine("0" + "          " + speed);

                    decimal ispeed = speed + 10;
                    while (ispeed < 201)
                    {
                        Console.WriteLine(ispeed + "         " + (ispeed * (decimal)KM));
                        ispeed +=10;



                    }


                }
                else
                {
                   // this stall and results in nothing when the disered input is not entered
                }
            }    
        }
    }
}

