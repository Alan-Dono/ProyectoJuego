using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer.ConcretClass.Atmosphere.Terrains;
using EntitiesLayer.Interfaces;

namespace EntitiesLayer.ConcretClass.Atmosphere.Enviroment
{
    public class Terrestrial : IEnviroment
    {
        private int id;
        private string _name;

        public int Id { get => id; set => id = value; }
        public string Name { get => _name; set => _name = value; }

        private static Terrestrial instance;
        private Terrestrial() { }
        public static Terrestrial GetInstance()
        {
            if (instance == null)
            {
                instance = new Terrestrial();
            }
            return instance;
        }
        public bool CanInhabit(ITerrains terrain)
        {
            return terrain is Land;
        }

        public IEnviroment getType()
        {
            return this;
        }

        public override string ToString()
        {
            return "Terrestre";
        }
    }
}
