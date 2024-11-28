using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Application of Singelton Design Pattern
// You Create a single "copy" of something this way you restrict creating and prevent duplication of something that
// is supposed to only have one version

namespace Day08
{
    internal class Network_Card
    {
        public int Id { get; set; }
        public string Version { get; set; }
        public int Year { get; set; }

        // Constructor is private to prevent external creation of objects
        private Network_Card()
        {
            Id = 500;
            Version = "X54-ixzw";
            Year = 2020;
        }


        // ================================================
        // The Tradiditioal Cpp Way (Lazy Initialization)
        // Lazy because it's created when it's first accessed not immediately with the class 
        
        static Network_Card card; // Static data Field to hold the singelton instance
        public static Network_Card getCard() 
        {
            if(card == null) { 
                card = new Network_Card();
            }
            return card;
        }

        // ================================================

        // using C# Property
        // same as the one above but it uses property instead 
        public static Network_Card Card
        {
            get{ 
                if (card == null)
                {
                    card = new Network_Card();
                }
                return card;
            }
        }

        // Can be Shortened to:
        public static Network_Card Ncard {
            get
            {
                if (card == null)
                {
                    card = new Network_Card();
                }

                // or card ??= new Network_Card();
                return card;
            }
        }

        // ================================================

        // Using Static Constructor (Eager Initialization) 
        // called Eager because the instance is created as soon as the class is loaded
        public static Network_Card Scard { get; }
        static Network_Card()
        {
            Scard = new Network_Card();
        }


        // Shortened to:
        public static Network_Card SScard { get; } = new Network_Card();


        //Note:
        // SScard, Scard, Ncard, Card Should All be named Card but i made it like this for the sake of explaining
        // one should only use the method (Eager or Lazy ) that suits their use case


    }
}
