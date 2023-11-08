using EntitiesLayer.Helpers;
using EntitiesLayer.Interfaces;
using EntitiesLayer.ConcretClass.EntityType;

namespace EntitiesLayer.Decorator.Evil
{
    public class AtkLessRandom : ItemDecorator
    {
        public AtkLessRandom(IInteractuable item) : base(item)
        {
        }

        public override void Interact(Entidad entidad)
        {
            entidad.AtkPoint -= NumberRandomGenerate.GenerateRandomNumber(1, 100);
        }
    }
}
