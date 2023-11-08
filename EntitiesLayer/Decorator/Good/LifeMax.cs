
using EntitiesLayer.ConcretClass.EntityType;
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
            base.Interact(entidad);
            entidad.VidaActual = entidad.VidaMaxima;
        }

    }
}
