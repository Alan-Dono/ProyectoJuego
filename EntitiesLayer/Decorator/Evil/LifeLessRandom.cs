
using EntitiesLayer.ConcretClass.EntityType;
using EntitiesLayer.Helpers;
using EntitiesLayer.Interfaces;

namespace EntitiesLayer.Decorator.Evil
{
    public class LifeLessRandom : ItemDecorator
    {
        public LifeLessRandom(IInteractuable item) : base(item)
        {
        }

        public override void Interact(Entidad entidad)
        {
            entidad.VidaActual -= NumberRandomGenerate.GenerateRandomNumber(1, 100);
        }
    }
}
