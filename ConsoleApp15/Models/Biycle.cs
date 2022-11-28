using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.Models
{
    internal class Biycle : Vehicle
    {
        public string _pedalkind;
            public string Pedaltime
        {
            get { return _pedalkind; }
            set
            {
                
                    _pedalkind = value;
                
            }
        }
    }
}
