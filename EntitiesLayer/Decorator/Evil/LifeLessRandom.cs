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
    public class LifeLessRandom : ItemDecorator
    {
        public LifeLessRandom(IInteractuable item) : base(item)
        {
        }

        public override void Interact(Entidad entidad)
        {
            entidad.VidaActual -= NumberRandomGenerate.GenerateRandomNumber(1, 100);
        }
    }
}
