
using EntitiesLayer.ConcretClass.Feed.Food;

using EntitiesLayer.Interfaces;

namespace EntitiesLayer.DietTypes
{
    public class Omnivoro : IDiet
    {
        private static Omnivoro instance;
        private Omnivoro() { }
        public static Omnivoro GetInstance()
        {
            if (instance == null)
            {
                instance = new Omnivoro();
            }
            return instance;
        }
        public bool canEat(IInteractuable food) // Esta implementacion va a devolver true si el alimento que recibe por parametro es vegetal o animal 
        {
            return food is Floors || food is Meat;
        }

        public override string ToString()
        {
            return "Omnivoro";
        }
    }
}
