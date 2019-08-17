using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020CharacterCreator
{
    class Dice
    {
        int number;
        int amount;
        int bonus;

        int RoleDice()
        {
            Random rnd = new Random();
            int temp = 0;
            for (int i = 0; i < amount; i++)
            { 
                temp += rnd.Next(number);
            }
            return temp;
        }

        public override string ToString()
        {
            return amount + "D" + number;
        }

        public Dice (int amount, int number)
        {
            this.amount = amount;
            this.number = number;
        }

        public Dice(int amount, int number, int bonus)
        {
            this.amount = amount;
            this.number = number;
            this.bonus = bonus;
        }
    }
}
