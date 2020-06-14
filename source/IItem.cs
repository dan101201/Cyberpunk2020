using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020Library
{
    public interface IItem
    {
        string Name { get;}
        string Desc { get;}
        double Cost { get;}

    }
}
