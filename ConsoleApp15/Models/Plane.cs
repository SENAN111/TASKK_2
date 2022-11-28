using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.Models
{
    internal class Plane:Vehicle
    {
        public float _winglenght;
        public float Winglenght

        {
            get { return _winglenght; }
            set
            {
                if(value>0)
                {
                    _winglenght = value;
                }
            }
        }
       

    }
}
