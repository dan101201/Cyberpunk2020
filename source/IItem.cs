using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberpunkWebsite.Backend
{
    interface IItem
    {
        string Name { get;}
        string Desc { get;}
        double Cost { get;}

    }
}
