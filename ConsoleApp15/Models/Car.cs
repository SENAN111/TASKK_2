using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.Models
{
    internal class Car :Vehicle
    {
        public int _doorcount;
        public int Doorcount
        {
            get { return _doorcount; }
            set {
                if(value>0)
                {
                    _doorcount = value;
                }
               }
        }
    }
}
