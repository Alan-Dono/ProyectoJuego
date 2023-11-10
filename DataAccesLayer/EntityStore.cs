using System.Collections.Generic;
using System.Linq;
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
            new Entidad("Tiburon", Carnivoro.GetInstance(), Acuatic.GetInstance(), AnimalKing.GetInstance(), 300, 200, 700, 300, 1),
            new Entidad("Leon", Carnivoro.GetInstance(), Terrestrial.GetInstance(), AnimalKing.GetInstance(), 100, 500, 100, 50, 1),
            new Entidad("León", Carnivoro.GetInstance(), Terrestrial.GetInstance(), AnimalKing.GetInstance(), 100, 500, 100, 50, 1),
            new Entidad("Lobo", Carnivoro.GetInstance(), Terrestrial.GetInstance(), AnimalKing.GetInstance(), 80, 400, 90, 60, 1),
            new Entidad("Oveja", Herbivoro.GetInstance(), Terrestrial.GetInstance(), AnimalKing.GetInstance(), 60, 300, 80, 400, 1),
            new Entidad("Águila", Carnivoro.GetInstance(), Aerial.GetInstance(), AnimalKing.GetInstance(), 20, 150, 70, 30, 1),
            new Entidad("Cocodrilo", Carnivoro.GetInstance(), Acuatic.GetInstance(), AnimalKing.GetInstance(), 150, 600, 110, 70, 1),
            new Entidad("Salmón", Herbivoro.GetInstance(), Acuatic.GetInstance(), AnimalKing.GetInstance(), 40, 200, 60, 20, 1)
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

        public Entidad GetEntidadById(int id)
        {
            Entidad entidadEncontrada = animals.FirstOrDefault(animal => animal.Id == id);
            return entidadEncontrada;
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
