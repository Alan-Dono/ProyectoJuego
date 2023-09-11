using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrearAnimales.EntitiesLayer.ConcretClass.EntityType;
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
            throw new NotImplementedException();
        }
    }
}
