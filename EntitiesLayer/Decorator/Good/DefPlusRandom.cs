
using EntitiesLayer.ConcretClass.EntityType;
using EntitiesLayer.Helpers;
using EntitiesLayer.Interfaces;

namespace EntitiesLayer.Decorator.Good
{
    public class DefPlusRandom : ItemDecorator
    {
        public DefPlusRandom(IInteractuable item) : base(item)
        {
        }

        public override void Interact(Entidad entidad)
        {
            base.Interact(entidad);
            entidad.DefPoint += NumberRandomGenerate.GenerateRandomNumber(1, 100);
        }
    }
}
