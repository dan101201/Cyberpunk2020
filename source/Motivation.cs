using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberpunkWebsite.Backend
{
    [Serializable]
    class Motivation
    {
        string _personalityTraits;
        string _mostValuedPerson;
        string _mostValued;
        string _feelingAbout;
        string _mostValuedPossesion;

        /// <summary>
        /// Randomly generates a Motivation
        /// </summary>
        /// <returns></returns>
        public static Motivation RandomlyGenerateMotivation()
        {
            return new Motivation();
            Random rnd = new Random();
            Motivation temp = new Motivation();
            //Reads text file full of motivations
            string[] lines = System.IO.File.ReadAllLines("Motivation.txt");
            int random = rnd.Next(1,10);
            temp._personalityTraits = lines[random];
            random = rnd.Next(1, 10);
            temp._mostValuedPerson = lines[random+10];
            random = rnd.Next(1, 10);
            temp._mostValued = lines[random+20];
            random = rnd.Next(1, 10);
            temp._feelingAbout = lines[random + 30];
            random = rnd.Next(1, 10);
            temp._mostValuedPossesion = lines[random + 40];
            return temp;
        }

    }
}
