using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.Models
{
    internal abstract class Vehicle: Engine
    {
        public double _drivetime;
        public double _drivepath;
        public double _avarage;
        public double _Oilcapsity;
        public double _Currentoil;
        public string _Fueltype;
        public double Drivetime
        {
            get { return _drivetime; }
            set
            {
                if (value > 0)
                {
                    _drivetime = value;
                }
            }
        }
        public double Drivepath
        {
            get { return _drivepath; }
            set
            {
                if (value > 0)
                {
                    Drivepath = value;
                }
            }
        }

        public Vehicle(double drivetime, double drivepath,Engine.Currentoil)
        {
            Drivetime = drivetime;
            Drivepath = drivepath;
            
           
        }

        public double Avaragespeed()
        {
            return Drivepath / Drivetime;

        }

    }
}
