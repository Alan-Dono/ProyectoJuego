
using EntitiesLayer.ConcretClass.Feed.Food;
using EntitiesLayer.Interfaces;

namespace EntitiesLayer.DietTypes
{
    public class Carnivoro : IDiet
    {
        private static Carnivoro instance;
        private Carnivoro() { }
        public static Carnivoro GetInstance()
        {
            if (instance == null)
            {
                instance = new Carnivoro();
            }
            return instance;
        }
        public bool canEat(IInteractuable food) // Esta implementacion va a devolver true si el alimento que recibe por parametro es Entidad 
        {
            return food is Meat;
        }

        public override string ToString()
        {
            return "Carnivoro";
        }
    }
}
