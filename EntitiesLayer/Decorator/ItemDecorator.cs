
using EntitiesLayer.ConcretClass.EntityType;
using EntitiesLayer.Interfaces;

namespace EntitiesLayer.Decorator
{
    public abstract class ItemDecorator : IInteractuable
    {
        protected IInteractuable _item;

        public ItemDecorator(IInteractuable item)
        {
            _item = item;
        }
        public virtual void Interact(Entidad entidad)
        {
            _item.Interact(entidad);
        }
    }
}
