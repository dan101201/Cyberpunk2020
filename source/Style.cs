using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020CharacterCreator
{
    class Style
    {

        static string clothing;
        static string hairstyle;
        static string affectation;


        static string[] clothes =
        {
            "Biker Leathers",
            "Blue jeans",
            "Corporate Suits",
            "Jumpsuits",
            "Miniskirts",
            "High Fashion",
            "Cammos",
            "Normal clothes",
            "Nude",
            "Bag Lady chic"
        };

        static string[] hairstyles =
        {
            "Mohawk",
            "Long & Ratty",
            "Short & Spiked",
            "Wild & all over",
            "Bald",
            "Striped",
            "Tinted",
            "Neat, short",
            "Short, curly",
            "Long, straight"
        };

        static string[] affectations =
        {
            "Tatoos",
            "Mirrorshades",
            "Ritual Scars",
            "Spiked gloves",
            "Nose Rings",
            "Earrings",
            "Long fingernails",
            "Spike heeled boots",
            "Weird Contact Lenses",
            "Fingerless gloves"
        };

        public void randomlySelectStyle()
        {
            Random rnd = new Random();
            int random = rnd.Next(1,10);
            clothing = clothes[random];
            random = rnd.Next(1, 10);
            hairstyle = hairstyles[random];
            random = rnd.Next(1, 10);
            affectation = affectations[random];
        }

    }
}
