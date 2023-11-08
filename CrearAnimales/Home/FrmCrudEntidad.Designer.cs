namespace SmallWord.Home
{
    partial class FrmCrudEntidad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRangoAtk = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDef = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAtk = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEnergia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDiet = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbHabitat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKingdom = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEntidades = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.entidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENVIROMENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KINGDOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ATK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RANGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LIFE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENERGY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entidadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.splitContainer1.Panel2.Controls.Add(this.btnNuevo);
            this.splitContainer1.Panel2.Controls.Add(this.btnClear);
            this.splitContainer1.Panel2.Controls.Add(this.btnSave);
            this.splitContainer1.Size = new System.Drawing.Size(1317, 693);
            this.splitContainer1.SplitterDistance = 584;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Teal;
            this.splitContainer2.Panel1.Controls.Add(this.label9);
            this.splitContainer2.Panel1.Controls.Add(this.txtRangoAtk);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.txtDef);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.txtAtk);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.txtEnergia);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.txtVida);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.cbDiet);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.cbHabitat);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.cbKingdom);
            this.splitContainer2.Panel1.Controls.Add(this.txtNombre);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Enabled = false;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvEntidades);
            this.splitContainer2.Size = new System.Drawing.Size(1317, 584);
            this.splitContainer2.SplitterDistance = 310;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(42, 518);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 25);
            this.label9.TabIndex = 35;
            this.label9.Text = "Rango de ataque";
            // 
            // txtRangoAtk
            // 
            this.txtRangoAtk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRangoAtk.Location = new System.Drawing.Point(218, 515);
            this.txtRangoAtk.Name = "txtRangoAtk";
            this.txtRangoAtk.Size = new System.Drawing.Size(127, 30);
            this.txtRangoAtk.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 457);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "Defensa";
            // 
            // txtDef
            // 
            this.txtDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDef.Location = new System.Drawing.Point(133, 454);
            this.txtDef.Name = "txtDef";
            this.txtDef.Size = new System.Drawing.Size(212, 30);
            this.txtDef.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 25);
            this.label7.TabIndex = 31;
            this.label7.Text = "Ataque";
            // 
            // txtAtk
            // 
            this.txtAtk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtk.Location = new System.Drawing.Point(129, 403);
            this.txtAtk.Name = "txtAtk";
            this.txtAtk.Size = new System.Drawing.Size(216, 30);
            this.txtAtk.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Energia";
            // 
            // txtEnergia
            // 
            this.txtEnergia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnergia.Location = new System.Drawing.Point(129, 355);
            this.txtEnergia.Name = "txtEnergia";
            this.txtEnergia.Size = new System.Drawing.Size(216, 30);
            this.txtEnergia.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Vida";
            // 
            // txtVida
            // 
            this.txtVida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVida.Location = new System.Drawing.Point(129, 303);
            this.txtVida.Name = "txtVida";
            this.txtVida.Size = new System.Drawing.Size(216, 30);
            this.txtVida.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Nombre";
            // 
            // cbDiet
            // 
            this.cbDiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDiet.FormattingEnabled = true;
            this.cbDiet.Location = new System.Drawing.Point(47, 183);
            this.cbDiet.Name = "cbDiet";
            this.cbDiet.Size = new System.Drawing.Size(298, 33);
            this.cbDiet.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Dieta";
            // 
            // cbHabitat
            // 
            this.cbHabitat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHabitat.FormattingEnabled = true;
            this.cbHabitat.Location = new System.Drawing.Point(47, 119);
            this.cbHabitat.Name = "cbHabitat";
            this.cbHabitat.Size = new System.Drawing.Size(298, 33);
            this.cbHabitat.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Habitat";
            // 
            // cbKingdom
            // 
            this.cbKingdom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKingdom.FormattingEnabled = true;
            this.cbKingdom.Location = new System.Drawing.Point(47, 55);
            this.cbKingdom.Name = "cbKingdom";
            this.cbKingdom.Size = new System.Drawing.Size(298, 33);
            this.cbKingdom.TabIndex = 20;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(129, 250);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(216, 30);
            this.txtNombre.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Reino";
            // 
            // dgvEntidades
            // 
            this.dgvEntidades.AllowUserToAddRows = false;
            this.dgvEntidades.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEntidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NAME,
            this.ENVIROMENT,
            this.KINGDOM,
            this.DIET,
            this.ATK,
            this.DEF,
            this.RANGE,
            this.LIFE,
            this.ENERGY});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEntidades.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEntidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEntidades.Location = new System.Drawing.Point(0, 0);
            this.dgvEntidades.Name = "dgvEntidades";
            this.dgvEntidades.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntidades.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEntidades.RowHeadersVisible = false;
            this.dgvEntidades.RowHeadersWidth = 51;
            this.dgvEntidades.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEntidades.RowTemplate.Height = 24;
            this.dgvEntidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntidades.Size = new System.Drawing.Size(1006, 584);
            this.dgvEntidades.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(47, 34);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 33);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(269, 34);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 33);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "id";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // NAME
            // 
            this.NAME.HeaderText = "Nombre";
            this.NAME.MinimumWidth = 6;
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            this.NAME.Width = 125;
            // 
            // ENVIROMENT
            // 
            this.ENVIROMENT.HeaderText = "Habitat";
            this.ENVIROMENT.MinimumWidth = 6;
            this.ENVIROMENT.Name = "ENVIROMENT";
            this.ENVIROMENT.ReadOnly = true;
            this.ENVIROMENT.Width = 125;
            // 
            // KINGDOM
            // 
            this.KINGDOM.HeaderText = "Reino";
            this.KINGDOM.MinimumWidth = 6;
            this.KINGDOM.Name = "KINGDOM";
            this.KINGDOM.ReadOnly = true;
            this.KINGDOM.Width = 125;
            // 
            // DIET
            // 
            this.DIET.HeaderText = "Dieta";
            this.DIET.MinimumWidth = 6;
            this.DIET.Name = "DIET";
            this.DIET.ReadOnly = true;
            this.DIET.Width = 125;
            // 
            // ATK
            // 
            this.ATK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ATK.HeaderText = "Ataque";
            this.ATK.MinimumWidth = 6;
            this.ATK.Name = "ATK";
            this.ATK.ReadOnly = true;
            this.ATK.Width = 144;
            // 
            // DEF
            // 
            this.DEF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DEF.HeaderText = "Defenza";
            this.DEF.MinimumWidth = 6;
            this.DEF.Name = "DEF";
            this.DEF.ReadOnly = true;
            this.DEF.Width = 159;
            // 
            // RANGE
            // 
            this.RANGE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.RANGE.HeaderText = "Rango";
            this.RANGE.MinimumWidth = 6;
            this.RANGE.Name = "RANGE";
            this.RANGE.ReadOnly = true;
            this.RANGE.Width = 137;
            // 
            // LIFE
            // 
            this.LIFE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.LIFE.HeaderText = "Vida";
            this.LIFE.MinimumWidth = 6;
            this.LIFE.Name = "LIFE";
            this.LIFE.ReadOnly = true;
            this.LIFE.Width = 111;
            // 
            // ENERGY
            // 
            this.ENERGY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ENERGY.HeaderText = "Energia";
            this.ENERGY.MinimumWidth = 6;
            this.ENERGY.Name = "ENERGY";
            this.ENERGY.ReadOnly = true;
            this.ENERGY.Width = 152;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(1155, 34);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(135, 33);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // FrmCrudEntidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 693);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmCrudEntidad";
            this.Text = "FrmHome";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entidadBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRangoAtk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDef;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAtk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEnergia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDiet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbHabitat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKingdom;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn energiaActualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn energyMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vidaMaximaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vidaActualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn atkPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeAtkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dietDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enviromentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kingdomDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource entidadBindingSource;
        private System.Windows.Forms.DataGridView dgvEntidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENVIROMENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn KINGDOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIET;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEF;
        private System.Windows.Forms.DataGridViewTextBoxColumn RANGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn LIFE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENERGY;
        private System.Windows.Forms.Button btnNuevo;
    }
}