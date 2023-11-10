using System;
using System.Windows.Forms;
using ControllersLayer;
using EntitiesLayer.ConcretClass.EntityType;
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
                dgvEntidades.Rows[rowIndex].Cells["ID"].Value = x.Id;
                dgvEntidades.Rows[rowIndex].Cells["NAME"].Value = x.Name;
                dgvEntidades.Rows[rowIndex].Cells["KINGDOM"].Value = x.Kingdom;
                dgvEntidades.Rows[rowIndex].Cells["ENVIROMENT"].Value = x.Enviroment;
                dgvEntidades.Rows[rowIndex].Cells["DIET"].Value = x.Diet;
                dgvEntidades.Rows[rowIndex].Cells["ATK"].Value = x.AtkPoint;
                dgvEntidades.Rows[rowIndex].Cells["DEF"].Value = x.DefPoint;
                dgvEntidades.Rows[rowIndex].Cells["RANGE"].Value = x.RangeAtk;
                dgvEntidades.Rows[rowIndex].Cells["LIFE"].Value = x.VidaMaxima;
                dgvEntidades.Rows[rowIndex].Cells["ENERGY"].Value = x.EnergyMax;
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        { // de esta manera el btnSave delega la responsabilidad de guardar o modificar a la controladora
            try
            {
                entityController.GuardarEntidad(
                    Convert.ToInt32(lblIdEntidad.Text),
                    txtNombre.Text,
                    (IDiet)cbDiet.SelectedItem,
                    (IEnviroment)cbHabitat.SelectedItem,
                    (Ikingdom)cbKingdom.SelectedItem,
                    Convert.ToInt32(txtEnergia.Text),
                    Convert.ToInt32(txtVida.Text),
                    Convert.ToInt32(txtAtk.Text),
                    Convert.ToInt32(txtDef.Text),
                    Convert.ToInt32(txtRangoAtk.Text)
                );
                llenarDgv();
                DesHabilitarComponentes();
                LimpiarComponentes();
            }
            catch (FormatException ex)
            {
                string fieldName = ex.Message.Split(' ')[0]; // Obtener el nombre del campo del mensaje de la excepción
                MessageBox.Show($"Error: El campo {fieldName} solo permite números.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            /*try
            {
                entityController.GuardarEntidad( 
                Convert.ToInt32(lblIdEntidad.Text),
                txtNombre.Text,
                (IDiet)cbDiet.SelectedItem,
                (IEnviroment)cbHabitat.SelectedItem,
                (Ikingdom)cbKingdom.SelectedItem,
                Convert.ToInt32(txtEnergia.Text),
                Convert.ToInt32(txtVida.Text),
                Convert.ToInt32(txtAtk.Text),
                Convert.ToInt32(txtDef.Text),
                Convert.ToInt32(txtRangoAtk.Text)
                );           
                llenarDgv();
                DesHabilitarComponentes();
                LimpiarComponentes();
            }
            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message );
            }*/

        }

        private void CargarCmBox()
        {
            frmController.llenarCmBox(cbDiet, dhrController.GetDiets()," -- Seleccione");
            frmController.llenarCmBox(cbHabitat, dhrController.GetEnviroments(), " -- Seleccione");
            frmController.llenarCmBox(cbKingdom, dhrController.GetKingdoms(), " -- Seleccione");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarComponentes();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LimpiarComponentes();
        }

        private void LimpiarComponentes()
        {
            CargarCmBox();
            txtAtk.Clear();
            txtDef.Clear();
            txtRangoAtk.Clear();
            txtEnergia.Clear();
            txtVida.Clear();
            txtNombre.Clear();
        }

        private void HabilitarComponentes()
        {
            splitContainer2.Panel1.Enabled = true;
            btnClear.Visible = true;
            btnSave.Visible = true;
            btnCancelar.Visible = true;
            btnNuevo.Visible = false;
            btnModificar.Visible = false;
        }

        private void DesHabilitarComponentes()
        {
            splitContainer2.Panel1.Enabled = false;
            btnClear.Visible = false;
            btnSave.Visible = false;
            btnCancelar.Visible = false;
            btnNuevo.Visible = true;
            btnModificar.Visible = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvEntidades.SelectedRows.Count > 0)
            {
                int idEntidad = Convert.ToInt32(dgvEntidades.SelectedRows[0].Cells["Id"].Value); 
                try
                {
                    Entidad entidad = entityController.GetEntidadById(idEntidad);
                    if (entidad != null)
                    {
                        txtNombre.Text = entidad.Name;
                        cbDiet.SelectedItem = entidad.Diet;// Lo que renege con ests combobox hasta que me di cuenta que nesecitaba un singelton
                        cbHabitat.SelectedItem = entidad.Enviroment;// porque esta comparando objetos distintos de la misma clase...
                        cbKingdom.SelectedItem = entidad.Kingdom;
                        txtEnergia.Text = entidad.EnergyMax.ToString();
                        txtVida.Text = entidad.VidaMaxima.ToString();
                        txtAtk.Text = entidad.AtkPoint.ToString();
                        txtDef.Text = entidad.DefPoint.ToString();
                        txtRangoAtk.Text = entidad.RangeAtk.ToString();
                        HabilitarComponentes();
                        btnModificar.Visible = false;
                        btnNuevo.Visible = false;
                        lblIdEntidad.Text = idEntidad.ToString();
                    }
                    else
                    {
                        // Manejar el caso donde no se encuentra la entidad con el ID seleccionado
                        MessageBox.Show("La entidad seleccionada no fue encontrada.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarComponentes();
            DesHabilitarComponentes();
        }

        private void bntEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEntidades.Rows.Count > 0)
            {
                entityController.EliminarEntidad(entityController.GetEntidadById(Convert.ToInt32(dgvEntidades.SelectedRows[0].Cells["Id"].Value)));
                llenarDgv();
            }
        }
    }
}
