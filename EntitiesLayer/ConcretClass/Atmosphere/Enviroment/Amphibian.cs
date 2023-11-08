﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer.ConcretClass.Atmosphere.Terrains;
using EntitiesLayer.Interfaces;

namespace EntitiesLayer.ConcretClass.Atmosphere.Enviroment
{
    public class Amphibian : IEnviroment
    {
        private int id;
        private string _name;

        public int Id { get => id; set => id = value; }
        public string Name { get => _name; set => _name = value; }

        public bool CanInhabit(ITerrains terrain)
        {
            return terrain is Water || terrain is Land;
        }

        public IEnviroment getType()
        {
            return this;
        }

        public override string ToString()
        {
            return "Anfibio";
        }
    }
}
