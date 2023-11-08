
using System.Collections.Generic;
using EntitiesLayer.ConcretClass.EntityType;
using EntitiesLayer.Interfaces;

namespace EntitiesLayer.ConcretClass.Maps
{
    public class Map
    {
        private List<ITerrains> _terrains;
        private List<Entidad> _entities;

        public List<ITerrains> Terrains { get => _terrains; set => _terrains = value; }
        public List<Entidad> Entities { get => _entities; set => _entities = value; }

    }
}
