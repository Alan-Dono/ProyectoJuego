﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer.ConcretClass.Atmosphere.Terrains;
using EntitiesLayer.DietTypes;
using EntitiesLayer.Interfaces;

namespace EntitiesLayer.ConcretClass.Atmosphere.Enviroment
{
    public class Acuatic : IEnviroment
    {
        private int id;
        private string _name;

        public int Id { get => id; set => id = value; }
        public string Name { get => _name; set => _name = value; }

        private static Acuatic instance;
        private Acuatic() { }
        public static Acuatic GetInstance()
        {
            if (instance == null)
            {
                instance = new Acuatic();
            }
            return instance;
        }
        public bool CanInhabit(ITerrains terrain)
        {
            return terrain is Water;
        }

        public IEnviroment getType()
        {
            return this;
        }
        public override string ToString()
        {
            return "Acuatico";
        }
    }
}
