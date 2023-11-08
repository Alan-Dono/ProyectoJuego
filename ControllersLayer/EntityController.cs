using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer;
using EntitiesLayer.ConcretClass.EntityType;
using EntitiesLayer.Interfaces;

namespace ControllersLayer
{
    public class EntityController
    {
        private List<Entidad> _entities;
        private static EntityController instance;

        private EntityController()
        {
            _entities = EntityBLL.GetAllAnimals();
        }

        public static EntityController GetInstance()
        {
            if (instance == null)
            {
                instance = new EntityController();
            }
            return instance;
        }

        private void RefrescarLista()
        {
            _entities = EntityBLL.GetAllAnimals();
        }

        public List<Entidad> GetEntidades()
        {
            return _entities;
        }

        public void crearEntidad(string name, IDiet diet, IEnviroment enviroment, Ikingdom kingdom, int energy, int vida, int atk, int def, int rangoAtk)
        {
            EntityBLL.AddAnimal(new Entidad(name, diet, enviroment, kingdom, energy, vida, atk, def, rangoAtk));
            RefrescarLista();
        }

        public void ModifiarEntidad(Entidad entidad)
        {
            EntityBLL.AlterAnimal(entidad);
            RefrescarLista();
        }

        public void EliminarEntidad(Entidad entidad)
        {
            EntityBLL.DeleteAnimal(entidad);
            RefrescarLista();
        }
    }
}
