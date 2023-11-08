using System;
using System.Windows.Forms;
using SmallWord.Home;
using EntitiesLayer.ConcretClass.Atmosphere.Enviroment;
using EntitiesLayer.ConcretClass.Atmosphere.Terrains;
using EntitiesLayer.ConcretClass.EntityType;
using EntitiesLayer.ConcretClass.Feed.Food;
using EntitiesLayer.ConcretClass.KingType;
using EntitiesLayer.Decorator.Good;
using EntitiesLayer.DietTypes;

namespace SmallWord
{
    public class Program
    {
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmCrudEntidad());

            //---------------------- Prueba de creacion de entidades -----------------------------
            Entidad pj1 = new Entidad("Leon", new Carnivoro(),new Terrestrial() ,new AnimalKing(), 100, 500, 100, 50, 1);
            Entidad pj2 = new Entidad("León", new Carnivoro(), new Terrestrial(), new AnimalKing(), 100, 500, 100, 50, 1);
            Entidad pj3 = new Entidad("Lobo", new Carnivoro(), new Terrestrial(), new AnimalKing(), 80, 400, 90, 60, 1);
            Entidad pj4 = new Entidad("Oveja", new Herbivoro(), new Terrestrial(), new AnimalKing(), 60, 300, 80, 400, 1);
            Entidad pj5 = new Entidad("Águila", new Carnivoro(), new Aerial(), new AnimalKing(), 20, 150, 70, 30, 1);
            Entidad pj6 = new Entidad("Cocodrilo", new Carnivoro(), new Acuatic(), new AnimalKing(), 150, 600, 110, 70, 1);
            Entidad pj7 = new Entidad("Salmón", new Herbivoro(), new Acuatic(), new AnimalKing(), 40, 200, 60, 20, 1);          
            Console.WriteLine(pj1.ToString() + "\n\n" + 
                              pj2.ToString() + "\n\n" + 
                              pj3.ToString() + "\n\n" + 
                              pj4.ToString() + "\n\n" + 
                              pj5.ToString());
            Console.ReadLine();
            //--------------------------Pruebas de Combate-----------------------
            Console.Clear();
            Console.WriteLine("Energia: " + pj1.EnergiaActual + "\n" + 
                              "Vida: " + pj1.VidaActual + "\n" + 
                              "Puntos de ataque:" +pj1.AtkPoint);
            Console.WriteLine("Energia: " + pj4.EnergiaActual + "\n" +
                              "Vida de la victima:" + pj4.VidaActual + "\n" + 
                              "Puntos de defensa: " + pj4.DefPoint);
            pj1.Atacar(pj4);
            Console.ReadLine();
            Console.WriteLine("Energia: " + pj1.EnergiaActual + "\n" + 
                              "Vida: " + pj1.VidaActual + "\n" + 
                              "Puntos de ataque:" + pj1.AtkPoint);
            Console.WriteLine("Energia: " + pj4.EnergiaActual + "\n" + 
                              "Vida de la victima:" + pj4.VidaActual + "\n" + 
                              "Puntos de defensa: " + pj4.DefPoint);
            Console.ReadLine();
            //--------------------------------- Pruebas Feed -------------------------------
            Console.Clear();
            Console.WriteLine("Energia antes de comer: " + pj2.EnergiaActual);
            pj2.SetEnergyLess(50);
            pj2.Feed(new Floors("Hojas",30));
            pj2.Feed(new Meat("Asado", 20));
            Console.WriteLine("Energia despues de comer: " + pj2.EnergiaActual);
            Console.ReadLine();
            //---------------------------- Purebas de Terrenos ------------------------
            Console.Clear();
            pj1.MoveThrough(new Land());
            pj1.MoveThrough(new Air());
            pj1.MoveThrough(new Water());
            Console.ReadLine();

            //--------------------------- Pruebas creacion de Items (Decorator) ------------------
            Console.Clear();
            Item item1 = new Item("CorazonOro", "Aumenta la vida de la entidad al maximo");
            EnergyMax itemDeco = new EnergyMax(item1);
            Console.WriteLine("Energia del Jugador antes de usar item: " + pj2.EnergiaActual);
            itemDeco.Interact(pj2);
            Console.WriteLine("Energia del Jugador Despues de usar item: " + pj2.EnergiaActual);
            Console.ReadLine();
            Console.WriteLine("Puntos de ataque antes de usar el mismo item: " +pj2.AtkPoint);
            Console.WriteLine("Puntos de defenza antes de usar el item: " + pj2.DefPoint);
            //Item item2 = new Item("Ataque", "Aumenta el ataque de la entidad al azar");
            AtkPlusRandom atk = new AtkPlusRandom(itemDeco);
            pj2.SetEnergyLess(50);
            DefPlusRandom def = new DefPlusRandom(itemDeco);
            Console.WriteLine("Energia del Jugador antes de usar el mismo item: " + pj2.EnergiaActual);
            atk.Interact(pj2);
            def.Interact(pj2);
            Console.WriteLine("Puntos de ataque despues de usar el mismo item: " + pj2.AtkPoint);

            Console.WriteLine("Puntos de defenza despues de usar el mismo item: " + pj2.DefPoint);
            Console.WriteLine("Energia del Jugador Despues de usar el mismo item: " + pj2.EnergiaActual);

            Console.ReadLine();
            
        }
    }
}
