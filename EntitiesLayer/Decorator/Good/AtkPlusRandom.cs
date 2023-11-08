
using EntitiesLayer.ConcretClass.EntityType;
using EntitiesLayer.Helpers;
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
            base.Interact(entidad);
            entidad.AtkPoint += NumberRandomGenerate.GenerateRandomNumber(1, 100);
        }
    }
}
