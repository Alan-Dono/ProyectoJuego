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
            dgvEntidades.Rows.Clear(); // Limpia todas las filas antes de volver a llenar el DataGridView
            foreach (var x in entityController.GetEntidades())
            {
                int rowIndex = dgvEntidades.Rows.Add();
                dgvEntidades.Rows[rowIndex].Cells[0].Value = x.Id;
                dgvEntidades.Rows[rowIndex].Cells[1].Value = x.Name;
                dgvEntidades.Rows[rowIndex].Cells[2].Value = x.Kingdom;
                dgvEntidades.Rows[rowIndex].Cells[3].Value = x.Enviroment;
                dgvEntidades.Rows[rowIndex].Cells[4].Value = x.Diet;
                dgvEntidades.Rows[rowIndex].Cells[5].Value = x.AtkPoint;
                dgvEntidades.Rows[rowIndex].Cells[6].Value = x.DefPoint;
                dgvEntidades.Rows[rowIndex].Cells[7].Value = x.RangeAtk;
                dgvEntidades.Rows[rowIndex].Cells[8].Value = x.VidaMaxima;
                dgvEntidades.Rows[rowIndex].Cells[9].Value = x.EnergyMax;
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            entityController.crearEntidad(
                    txtNombre.Text,
                    (IDiet)cbDiet.SelectedItem,
                    (IEnviroment)cbHabitat.SelectedItem,
                    (Ikingdom)cbKingdom.SelectedItem,
                    Convert.ToInt32(txtEnergia.Text),
                    Convert.ToInt32(txtVida.Text),
                    Convert.ToInt32(txtAtk.Text),
                    Convert.ToInt32(txtDef.Text),
                    Convert.ToInt32(txtRangoAtk.Text)
                ); ;
            llenarDgv();
        }

        private void CargarCmBox()
        {
            frmController.llenarCmBox(cbDiet, dhrController.GetDiets());
            frmController.llenarCmBox(cbHabitat, dhrController.GetEnviroments());
            frmController.llenarCmBox(cbKingdom, dhrController.GetKingdoms());
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel1.Enabled = true;
        }
    }
}
