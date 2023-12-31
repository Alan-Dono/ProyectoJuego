﻿
using EntitiesLayer.Interfaces;



namespace EntitiesLayer.ConcretClass.Atmosphere.Enviroment
{
    public class Aerial : IEnviroment
    {
        private int id;
        private string _name;

        public int Id { get => id; set => id = value; }
        public string Name { get => _name; set => _name = value; }

        private static Aerial instance;
        private Aerial() { }
        public static Aerial GetInstance()
        {
            if (instance == null)
            {
                instance = new Aerial();
            }
            return instance;
        }
        public bool CanInhabit(ITerrains terrain)
        {
            return terrain is ITerrains;
        }

        public IEnviroment getType()
        {
            return this;
        }
        public override string ToString()
        {
            return "Aerio";
        }
    }
}
