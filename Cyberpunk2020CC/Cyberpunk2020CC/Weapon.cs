using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020CharacterCreator
{
    
    class Weapon
    {
        
        enum Con
        {
            P,
            J,
            L,
            N
        }

        enum Avail
        {
            E,
            C,
            P,
            R
        }

        enum Rel
        {
            VR,
            ST,
            UR
        }

        string name;

        //Weapon Accuracy
        int wa;

        //Concealability, P for Pocket, Pants, Leg or Sleeve. J for Jacket, Coat or Shoulder Rig
        //L for Long Coat, N for Can't be hidden
        Con concealability;

        Avail availability;

        Dice damage;

        int shots;

        //Rate of fire
        int rof;

        Rel reliability;

        int cost;

    }
}
