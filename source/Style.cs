using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020Library
{
    [Serializable]
    public class Style
    {

        public string clothing;
        public string hairstyle;
        public string affectation;


        static string[] _clothes =
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

        static string[] _hairstyles =
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

        static string[] _affectations =
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

        public void RandomlySelectStyle()
        {
            Random rnd = new Random();
            int random = rnd.Next(1,10);
            clothing = _clothes[random];
            random = rnd.Next(1, 10);
            hairstyle = _hairstyles[random];
            random = rnd.Next(1, 10);
            affectation = _affectations[random];
        }

    }
}
