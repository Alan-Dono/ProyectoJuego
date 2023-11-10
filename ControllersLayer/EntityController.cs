using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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

        public Entidad GetEntidadById(int id)
        {
            Entidad EntidadEncontrada = EntityBLL.GetEntidadById(id);
            return EntidadEncontrada;
        }

        public void GuardarEntidad(int id, string nombre, IDiet diet, IEnviroment habitat, Ikingdom kingdom, int energia, int vida, int ataque, int defensa, int rangoAtaque)
        {
            Entidad entidad = GetEntidadById(id);

            if (entidad == null)
            {
                crearEntidad(nombre, diet, habitat, kingdom, energia, vida, ataque, defensa, rangoAtaque);
            }
            else
            {
                entidad.Id = id;
                entidad.Name = nombre;
                entidad.Diet = diet;
                entidad.Enviroment = habitat;
                entidad.Kingdom = kingdom;
                entidad.EnergyMax = energia;
                entidad.VidaMaxima = vida;
                entidad.AtkPoint = ataque;
                entidad.DefPoint = defensa;
                entidad.RangeAtk = rangoAtaque;
                ModifiarEntidad(entidad);
            }
            RefrescarLista();
        }


        private void crearEntidad(string name, IDiet diet, IEnviroment enviroment, Ikingdom kingdom, int energy, int vida, int atk, int def, int rangoAtk)
        {
            try
            {
                EntityBLL.AddAnimal(new Entidad(name, diet, enviroment, kingdom, energy, vida, atk, def, rangoAtk));
            }
            catch(Exception e) { MessageBox.Show(e.Message); }
        }

        private void ModifiarEntidad(Entidad entidad)
        {

            try
            {
                EntityBLL.AlterAnimal(entidad);
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        public void EliminarEntidad(Entidad entidad)
        {
            EntityBLL.DeleteAnimal(entidad);
            RefrescarLista();
        }
    }
}
