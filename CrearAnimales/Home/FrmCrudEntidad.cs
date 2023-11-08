using System;
using System.Windows.Forms;
using ControllersLayer;
using EntitiesLayer.Interfaces;



namespace SmallWord.Home
{
    public partial class FrmCrudEntidad : Form
    {
        private readonly EntityController entityController;
        private readonly FormController frmController;
        private readonly DHRController dhrController;

        public FrmCrudEntidad()
        {
            InitializeComponent();
            entityController = EntityController.GetInstance();
            frmController = FormController.GetInstance();
            dhrController = DHRController.GetInstance();
            CargarCmBox();
            llenarDgv();
        }

        public void llenarDgv()
        {

            dgvEntidades.DataSource = entityController.GetEntidades();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            entityController.crearEntidad(
                    txtNombre.ToString(),
                    (IDiet)cbDiet,
                    (IEnviroment)cbHabitat,
                    (Ikingdom)cbKingdom,
                    Convert.ToInt32(txtEnergia),
                    Convert.ToInt32(txtVida),
                    Convert.ToInt32(txtAtk),
                    Convert.ToInt32(txtDef),
                    Convert.ToInt32(txtRangoAtk)
                ); ;
        }

        private void CargarCmBox()
        {
            frmController.llenarCmBox(cbDiet, dhrController.GetDiets());
            frmController.llenarCmBox(cbHabitat, dhrController.GetEnviroments());
            frmController.llenarCmBox(cbKingdom, dhrController.GetKingdoms());
        }
 
    }
}
