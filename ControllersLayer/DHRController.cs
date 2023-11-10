using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer.ConcretClass.Atmosphere.Enviroment;
using EntitiesLayer.ConcretClass.KingType;
using EntitiesLayer.DietTypes;
using EntitiesLayer.Interfaces;

namespace ControllersLayer
{
    public class DHRController
    {
        private static DHRController instance;

        private DHRController() { }

        public static DHRController GetInstance()
        {
            if (instance == null)
            {
                instance = new DHRController();
            }
            return instance;
        }

        public List<IDiet> GetDiets()
        {
            return new List<IDiet>()
            {
                Carnivoro.GetInstance(),
                Herbivoro.GetInstance(),
                Omnivoro.GetInstance()
            };
        }

        public List<IEnviroment> GetEnviroments()
        {
            return new List<IEnviroment>()
            {
                Acuatic.GetInstance(),
                Aerial.GetInstance(),
                Amphibian.GetInstance(),
                Terrestrial.GetInstance()
            };
        }

        public List<Ikingdom> GetKingdoms()
        {
            return new List<Ikingdom>()
            {
                AnimalKing.GetInstance(),
                Vegetal.GetInstance()
            };
        }


    }
}
