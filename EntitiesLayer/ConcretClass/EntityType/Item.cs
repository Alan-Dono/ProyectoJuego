using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrearAnimales.EntitiesLayer.ConcretClass.EntityType;
using EntitiesLayer.Interfaces;

namespace EntitiesLayer.ConcretClass.EntityType
{
    public class Item : IInteractuable
    {
        private string _name;
        private string _description;

        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }


        public Item(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public void Interact(Entidad entidad)
        {
            throw new NotImplementedException();
        }
    }
}
