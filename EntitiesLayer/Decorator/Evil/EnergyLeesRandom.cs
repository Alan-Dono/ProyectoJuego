using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrearAnimales.EntitiesLayer.ConcretClass.EntityType;
using CrearAnimales.EntitiesLayer.Helpers;
using EntitiesLayer.Interfaces;

namespace EntitiesLayer.Decorator.Evil
{
    public class EnergyLeesRandom : ItemDecorator
    {
        public EnergyLeesRandom(IInteractuable item) : base(item)
        {
        }

        public override void Interact(Entidad entidad)
        {
            entidad.EnergiaActual -= NumberRandomGenerate.GenerateRandomNumber(1 ,100);
        }
    }
}
