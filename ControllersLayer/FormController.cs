using System.Collections.Generic;
using EntitiesLayer.DietTypes;
using EntitiesLayer.ConcretClass.Atmosphere.Enviroment;
using EntitiesLayer.ConcretClass.KingType;
using EntitiesLayer.Interfaces;
using System.Windows.Forms;
using System;

namespace ControllersLayer
{
    public class FormController
    {
        private static FormController instance;
         
        private FormController() { }

        public static FormController GetInstance()
        {
            if (instance == null)
            {
                instance = new FormController();
            }
            return instance;
        }

        public void llenarCmBox<T>(ComboBox comboBox, List<T> lista, string cabecera)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add(cabecera);
            foreach (T t in lista)
            {
                comboBox.Items.Add(t);
            }
            comboBox.SelectedIndex = 0;
        }
    }
}
