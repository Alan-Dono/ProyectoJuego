using EntitiesLayer.Interfaces;

namespace EntitiesLayer.Interfaces
{
    public interface IDiet
    {
        bool canEat(IInteractuable food);
    }
}
