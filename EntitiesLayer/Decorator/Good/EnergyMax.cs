
using EntitiesLayer.ConcretClass.EntityType;
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
            base.Interact(entidad);
            entidad.EnergiaActual = entidad.EnergyMax;
        }

    }
}
