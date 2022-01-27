using System;

namespace deliverable1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string repeat = "";
            do
            {

                double slicesPerLoaf = 28;
                double pbPerJar = 32;
                double jellyPerJar = 48;

                Console.Write(" How many people are eating today? ");
                int people = int.Parse(Console.ReadLine());
                double slices = people * 2;
                double pb = people * 2;
                double jelly = people * 4;
                //Console.Write(slices);
                double loavesNeeded = slices / slicesPerLoaf;
                double loavesRounded = Math.Ceiling(loavesNeeded);
                //Console.Write(loavesRound);
                double pbNeeded = pb / pbPerJar;
                double jellyNeeded = jelly / jellyPerJar;
                double pbRounded = Math.Ceiling(pbNeeded);
                double jellyRounded = Math.Ceiling(jellyNeeded);
                //Console.WriteLine(jellyRounded);
                //Console.WriteLine(pbRounded);
                Console.WriteLine("\n Ok, so for " + people + " people, we'll need:\n\n " +
                    slices + " slices of bread,\n " +
                    pb + " tablespoons of peanut butter,\n and " +
                    jelly + " teaspoons of jelly.\n ");
                Console.WriteLine("\n That means we'll need...\n\n ");
                Console.WriteLine(" " + loavesRounded + " loaves of bread,\n " +
                    pbRounded + " jars of peanut butter,\n and " +
                    jellyRounded + " jars of jelly.\n\n");
                Console.Write(" Would you like to enter a new number? Enter y or yes to go again. Type anything else to quit: ");
                repeat = Console.ReadLine();



            } while (repeat == "y" || repeat == "yes");

            Console.WriteLine("\n\n Goodbye!");




        }
    }
}
