using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020Library
{
    [Serializable]
    public class Dice
    {
        int _number;
        int _amount;
        int _bonus;

        int RoleDice()
        {
            Random rnd = new Random();
            int temp = 0;
            for (int i = 0; i < _amount; i++)
            { 
                temp += rnd.Next(_number);
            }
            return temp;
        }

        public override string ToString()
        {
            return _amount + "D" + _number;
        }

        public Dice (int amount, int number)
        {
            this._amount = amount;
            this._number = number;
        }

        public Dice(int amount, int number, int bonus)
        {
            this._amount = amount;
            this._number = number;
            this._bonus = bonus;
        }

        public Dice(string line)
        {
            
            this._number = line[0];
            this._amount = line[2];
            this._bonus = int.Parse(line.Split('+')[1].Trim());

        }

    }
}
