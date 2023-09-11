using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrearAnimales.EntitiesLayer.ConcretClass.EntityType;
using EntitiesLayer.Interfaces;

namespace EntitiesLayer.Decorator.Good
{
    public class EnergyMax : ItemDecorator
    {
        public EnergyMax(IInteractuable item) : base(item)
        {
            
        }

        public override void Interact(Entidad entidad)
        {
            entidad.EnergiaActual = entidad.EnergyMax;
        }

    }
}
