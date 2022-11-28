using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.Models
{
    internal interface Engine
    {
        double Oilcapsity { get; set; }
        double Currentoil { get; set; }
        string Fueltype { get; set; }
        void Reaminoil();
    }
}
