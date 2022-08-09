using System;

namespace ChristmasWithTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmas = new Christmas();

            var xmasDay = Christmas.Day.Thursday;

            //TODO set Santa's name to Kris Kringle
            var xmasSanta = "Kris Kringle";

            //TODO Insert 3 presents you would like for xmas.  They must be strings
            var present = "XBOX,TOYS,BASKETBALL"; 

            //TODO Set the TreeHeight to 10
           var treeHeight = 10;

            Console.WriteLine($"This year christmas falls on {xmasDay} ");
            Console.WriteLine($"Our tree will be {treeHeight} feet high ");
            Console.WriteLine($"Here are the presents we would like:{present}");

    

            /* foreach (var presents in xmas.Presents)
            {
                Console.WriteLine($"    {present}");
            } */

            Console.WriteLine($" We like to call Santa, {xmasSanta}");

            Console.ReadLine();
        }
    }
}
