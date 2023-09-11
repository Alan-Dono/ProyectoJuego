using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrearAnimales.EntitiesLayer.ConcretClass.EntityType;
using EntitiesLayer.Interfaces;

namespace EntitiesLayer.Decorator
{
    public class LifeMax : ItemDecorator
    {
        public LifeMax(IInteractuable item) : base(item)
        {
        
        }

        public override void Interact(Entidad entidad)
        {
            entidad.EnergiaActual = entidad.EnergyMax;
        }

    }
}
