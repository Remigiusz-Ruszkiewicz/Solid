using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.L
{
    public abstract class Vechicle
    {
        public abstract string Drive();
    }
        public abstract class Forklift : Vechicle
        {
            public virtual string LiftTheLoad()
            {
                return "Podnoszę ładunek";
            }
        }
        public class ElectricForklift : Forklift
        {
            public override string Drive()
            {
                return "Wózek elektryczny jedzie";
            }
            public override string LiftTheLoad()
            {
                return $"{base.LiftTheLoad()} wózkiem elektrycznym";
            }
        }
        public class Car : Vechicle
        {
            public override string Drive()
            {
                return "Samochód jedzie";
            }
        }
    }

