using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer.ConcretClass.Atmosphere.Enviroment;
using EntitiesLayer.Interfaces;

namespace EntitiesLayer.ConcretClass.KingType
{
    public class AnimalKing : Ikingdom
    {

        private static AnimalKing instance;
        private AnimalKing() { }
        public static AnimalKing GetInstance()
        {
            if (instance == null)
            {
                instance = new AnimalKing();
            }
            return instance;
        }
        string Ikingdom.GetType()
        {
            return GetType().Name;
        }

        public override string ToString()
        {
            return "Animal";
        }
    }
}
