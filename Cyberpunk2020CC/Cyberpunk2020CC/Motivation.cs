using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020CharacterCreator
{
    class Motivation
    {
        string personalityTraits;
        string mostValuedPerson;
        string mostValued;
        string feelingAbout;
        string mostValuedPossesion;

        /// <summary>
        /// Randomly generates a Motivation
        /// </summary>
        /// <returns></returns>
        public static Motivation randomlyGenerateMotivation()
        {
            Random rnd = new Random();
            Motivation temp = new Motivation();
            //Reads text file full of motivations
            string[] lines = System.IO.File.ReadAllLines("Motivation.txt");
            int random = rnd.Next(1,10);
            temp.personalityTraits = lines[random];
            random = rnd.Next(1, 10);
            temp.mostValuedPerson = lines[random+10];
            random = rnd.Next(1, 10);
            temp.mostValued = lines[random+20];
            random = rnd.Next(1, 10);
            temp.feelingAbout = lines[random + 30];
            random = rnd.Next(1, 10);
            temp.mostValuedPossesion = lines[random + 40];
            return temp;
        }

    }
}
