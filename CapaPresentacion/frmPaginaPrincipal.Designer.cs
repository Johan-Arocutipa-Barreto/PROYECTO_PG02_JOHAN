namespace CapaPresentacion
{
    partial class frmPaginaPrincipal
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
            this.btnCrearEquipo = new System.Windows.Forms.Button();
            this.gpbAcciones = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvEquiposUsuario = new System.Windows.Forms.DataGridView();
            this.btnInvitar = new System.Windows.Forms.Button();
            this.txtIDEquipo = new System.Windows.Forms.TextBox();
            this.gpbAcciones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquiposUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearEquipo
            // 
            this.btnCrearEquipo.Location = new System.Drawing.Point(29, 32);
            this.btnCrearEquipo.Name = "btnCrearEquipo";
            this.btnCrearEquipo.Size = new System.Drawing.Size(89, 23);
            this.btnCrearEquipo.TabIndex = 0;
            this.btnCrearEquipo.Text = "Crear Equipo";
            this.btnCrearEquipo.UseVisualStyleBackColor = true;
            this.btnCrearEquipo.Click += new System.EventHandler(this.btnCrearEquipo_Click);
            // 
            // gpbAcciones
            // 
            this.gpbAcciones.Controls.Add(this.btnCrearEquipo);
            this.gpbAcciones.Location = new System.Drawing.Point(22, 35);
            this.gpbAcciones.Name = "gpbAcciones";
            this.gpbAcciones.Size = new System.Drawing.Size(166, 324);
            this.gpbAcciones.TabIndex = 1;
            this.gpbAcciones.TabStop = false;
            this.gpbAcciones.Text = "Acciones";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvEquiposUsuario);
            this.groupBox1.Location = new System.Drawing.Point(232, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 217);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Equipos Creados";
            // 
            // dgvEquiposUsuario
            // 
            this.dgvEquiposUsuario.AllowUserToAddRows = false;
            this.dgvEquiposUsuario.AllowUserToDeleteRows = false;
            this.dgvEquiposUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquiposUsuario.Location = new System.Drawing.Point(23, 32);
            this.dgvEquiposUsuario.Name = "dgvEquiposUsuario";
            this.dgvEquiposUsuario.ReadOnly = true;
            this.dgvEquiposUsuario.Size = new System.Drawing.Size(437, 150);
            this.dgvEquiposUsuario.TabIndex = 0;
            this.dgvEquiposUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquiposUsuario_CellClick);
            // 
            // btnInvitar
            // 
            this.btnInvitar.Location = new System.Drawing.Point(255, 259);
            this.btnInvitar.Name = "btnInvitar";
            this.btnInvitar.Size = new System.Drawing.Size(75, 23);
            this.btnInvitar.TabIndex = 3;
            this.btnInvitar.Text = "Invitar Jugadores";
            this.btnInvitar.UseVisualStyleBackColor = true;
            this.btnInvitar.Click += new System.EventHandler(this.btnInvitar_Click);
            // 
            // txtIDEquipo
            // 
            this.txtIDEquipo.Location = new System.Drawing.Point(359, 261);
            this.txtIDEquipo.Name = "txtIDEquipo";
            this.txtIDEquipo.ReadOnly = true;
            this.txtIDEquipo.Size = new System.Drawing.Size(100, 20);
            this.txtIDEquipo.TabIndex = 4;
            // 
            // frmPaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIDEquipo);
            this.Controls.Add(this.btnInvitar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbAcciones);
            this.Name = "frmPaginaPrincipal";
            this.Text = "frmPaginaPrincipal";
            this.Load += new System.EventHandler(this.frmPaginaPrincipal_Load);
            this.gpbAcciones.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquiposUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearEquipo;
        private System.Windows.Forms.GroupBox gpbAcciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvEquiposUsuario;
        private System.Windows.Forms.Button btnInvitar;
        private System.Windows.Forms.TextBox txtIDEquipo;
    }
}