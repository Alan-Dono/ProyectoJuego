using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrearAnimales.EntitiesLayer.ConcretClass.EntityType;
using CrearAnimales.EntitiesLayer.Helpers;
using EntitiesLayer.Interfaces;

namespace EntitiesLayer.Decorator.Good
{
    public class AtkPlusRandom : ItemDecorator
    {
        
        public AtkPlusRandom(IInteractuable item) : base(item)
        {
        }

        public override void Interact(Entidad entidad)
        {
            entidad.AtkPoint += NumberRandomGenerate.GenerateRandomNumber(1, 100);
        }
    }
}
