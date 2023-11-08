
using EntitiesLayer.ConcretClass.EntityType;
using EntitiesLayer.Interfaces;

namespace EntitiesLayer.ConcretClass.Feed.Food
{
    public class Meat : IInteractuable
    {
        private string _name;
        private int _calories;

        public string Name { get => _name; set => _name = value; }
        public int Calories { get => _calories; set => _calories = value; }

        public Meat(string name, int calories)
        {
            Name = name;
            Calories = calories;
        }

        public void Interact(Entidad entidad)
        {
            entidad.SetEnergyPlus(Calories);
        }
    }
}
