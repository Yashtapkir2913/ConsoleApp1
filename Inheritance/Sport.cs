using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Inheritance
{
        // Base class
        public class Sport
        {
            public string Name { get; set; }  

            public Sport()
            {
                Name = "General Sport";
                Console.WriteLine("Sport Constructor called");
            }
        }

        // Derived class 1
        public class OutdoorSport : Sport
        {
            public int Players { get; set; }        // Property 2

            public OutdoorSport()
            {
                Players = 11;
                Console.WriteLine("OutdoorSport Constructor called");
            }
        }

        // Derived class 2
        public class IndoorSport : Sport
        {
            public string VenueType { get; set; }   // Property 3

            public IndoorSport()
            {
                VenueType = "Indoor Court";
                Console.WriteLine("IndoorSport Constructor called");
            }
        }

        // Further derived from OutdoorSport
        public class Cricket : OutdoorSport
        {
            public string TeamCaptain { get; set; }  // Property 4

            public Cricket()
            {
                Name = "Cricket";
                TeamCaptain = "Rohit Sharma";
                Console.WriteLine("Cricket Constructor called");
            }
        }

        // Further derived from OutdoorSport
        public class Football : OutdoorSport
        {
            public string League { get; set; }       // Property 5

            public Football()
            {
                Name = "Football";
                League = "Premier League";
                Console.WriteLine("Football Constructor called");
            }
        }

        // Further derived from IndoorSport
        public class Badminton : IndoorSport
        {
            public string Champion { get; set; }     // Property 6

            public Badminton()
            {
                Name = "Badminton";
                Champion = "P. V. Sindhu";
                Console.WriteLine("Badminton Constructor called");
            }
        }

        // Further derived from IndoorSport
        public class TableTennis : IndoorSport
        {
            public string Equipment { get; set; }    // Property 7

            public TableTennis()
            {
                Name = "Table Tennis";
                Equipment = "Paddle and Ball";
                Console.WriteLine("TableTennis Constructor called");
            }
        }

        // Tester class
        public class TestSports
        {
            public static void My1()
            {
                Console.WriteLine("Creating Cricket object:\n");
                Cricket c = new Cricket();
                Console.WriteLine($"Name: {c.Name}, Players: {c.Players}, Captain: {c.TeamCaptain}");

                Console.WriteLine("\nCreating Football object:\n");
                Football f = new Football();
                Console.WriteLine($"Name: {f.Name}, Players: {f.Players}, League: {f.League}");

                Console.WriteLine("\nCreating Badminton object:\n");
                Badminton b = new Badminton();
                Console.WriteLine($"Name: {b.Name}, Venue: {b.VenueType}, Champion: {b.Champion}");

                Console.WriteLine("\nCreating TableTennis object:\n");
                TableTennis t = new TableTennis();
                Console.WriteLine($"Name: {t.Name}, Venue: {t.VenueType}, Equipment: {t.Equipment}");
            }
        }
   

}
