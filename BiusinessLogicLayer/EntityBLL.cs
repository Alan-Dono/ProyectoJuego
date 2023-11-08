using System.Collections.Generic;
using DataAccesLayer;
using EntitiesLayer.ConcretClass.EntityType;

namespace BusinessLogicLayer
{
    public static class EntityBLL
    {

        private static EntityStore _almacen; // Campo privado para almacenar la instancia de EntityStore

        private static EntityStore Almacen
        {
            get { return _almacen; } // Propiedad pública para acceder al campo _almacen
            set { _almacen = value; }
        }

        private static void SetAnimalStoreInstance()
        {
            if (Almacen == null) // Verifica si la instancia de EntityStore no ha sido asignada previamente
            {
                EntityStore animalStore = EntityStore.GetInstance(); // Obtiene la instancia de EntityStore
                Almacen = animalStore; // Asigna la instancia a la propiedad Almacen
            }
        }

        #region CRUD_Animales
        public static void AddAnimal(Entidad animal)
        {
            SetAnimalStoreInstance();
            Almacen.AddAnimal(animal);
        }

        public static List<Entidad> GetAllAnimals()
        {
            SetAnimalStoreInstance();
            return Almacen.GetAllAnimals();
        }

        public static Entidad AlterAnimal(Entidad animal)
        {
            SetAnimalStoreInstance();
            // Realizar las operaciones de modificación necesarias
            return Almacen.AlterAnimal(animal);
        }

        public static void DeleteAnimal(Entidad animal)
        {
            SetAnimalStoreInstance();
            Almacen.DeleteAnimal(animal);
        }
        #endregion
       
    }
}

