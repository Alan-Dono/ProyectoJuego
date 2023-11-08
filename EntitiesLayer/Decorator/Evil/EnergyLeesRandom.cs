
using EntitiesLayer.ConcretClass.EntityType;
using EntitiesLayer.Helpers;
using EntitiesLayer.Interfaces;

namespace EntitiesLayer.Decorator.Evil
{
    public class EnergyLeesRandom : ItemDecorator
    {
        public EnergyLeesRandom(IInteractuable item) : base(item)
        {
        }

        public override void Interact(Entidad entidad)
        {
            entidad.EnergiaActual -= NumberRandomGenerate.GenerateRandomNumber(1 ,100);
        }
    }
}
