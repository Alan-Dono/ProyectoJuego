using System.Collections.Generic;
using EntitiesLayer.ConcretClass.Atmosphere.Enviroment;
using EntitiesLayer.ConcretClass.EntityType;
using EntitiesLayer.ConcretClass.KingType;
using EntitiesLayer.DietTypes;

namespace DataAccesLayer
{
    public class EntityStore
    {
        //private List<Entidad> animals = new List<Entidad>();
        private List<Entidad> animals = new List<Entidad> // Harcodeada para pruebas
        {
            new Entidad("Leon", new Carnivoro(), new Terrestrial(), new AnimalKing(), 100, 500, 100, 50, 1),
            new Entidad("León", new Carnivoro(), new Terrestrial(), new AnimalKing(), 100, 500, 100, 50, 1),
            new Entidad("Lobo", new Carnivoro(), new Terrestrial(), new AnimalKing(), 80, 400, 90, 60, 1),
            new Entidad("Oveja", new Herbivoro(), new Terrestrial(), new AnimalKing(), 60, 300, 80, 400, 1),
            new Entidad("Águila", new Carnivoro(), new Aerial(), new AnimalKing(), 20, 150, 70, 30, 1),
            new Entidad("Cocodrilo", new Carnivoro(), new Acuatic(), new AnimalKing(), 150, 600, 110, 70, 1),
            new Entidad("Salmón", new Herbivoro(), new Acuatic(), new AnimalKing(), 40, 200, 60, 20, 1)
        };
        private static EntityStore instance;

        private EntityStore() { }

        public static EntityStore GetInstance()
        {
            if (instance == null)
            {
                instance = new EntityStore();
            }
            return instance;
        }

        public void AddAnimal(Entidad animal)
        {
            animals.Add(animal);
        }

        public List<Entidad> GetAllAnimals()
        {
            // Retornar una copia de la lista para evitar modificaciones externas
            return animals;
        }

        public Entidad AlterAnimal(Entidad animal)
        {
            // Realizar las operaciones necesarias para alterar el animal
            if (animals.Contains(animal))
            {
                int index = animals.IndexOf(animal); // Obtener el índice del animal en la lista
                animals[index] = animal; // Reemplazar el objeto existente con el objeto modificado
            }
            return animal;
        }


        public void DeleteAnimal(Entidad animal)
        {
            if (animals.Contains(animal))
            {
                animals.Remove(animal);
            }
        }
    }
}
