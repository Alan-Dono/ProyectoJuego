
using EntitiesLayer.ConcretClass.Feed.Food;
using EntitiesLayer.Interfaces;

namespace EntitiesLayer.DietTypes
{
    public class Herbivoro : IDiet
    {
        private static Herbivoro instance;
        private Herbivoro() { }
        public static Herbivoro GetInstance()
        {
            if (instance == null)
            {
                instance = new Herbivoro();
            }
            return instance;
        }
        public bool canEat(IInteractuable food) // Esta implementacion va a devolver true si el alimento que recibe por parametro es vegetal 
        {
            return food is Floors;
        }

        public override string ToString()
        {
            return "Hervivoro";
        }
    }
}
