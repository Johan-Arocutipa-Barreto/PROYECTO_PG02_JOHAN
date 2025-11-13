namespace CapaPresentacion
{
    partial class frmCrearEquipo
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombreEquipo = new System.Windows.Forms.Label();
            this.txtNombreEquipo = new System.Windows.Forms.TextBox();
            this.dpbDatosEquipo = new System.Windows.Forms.GroupBox();
            this.btnSubirFoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblCreador = new System.Windows.Forms.Label();
            this.txtCreador = new System.Windows.Forms.TextBox();
            this.btnCrearEquipo = new System.Windows.Forms.Button();
            this.dpbDatosEquipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(116, 33);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(68, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Crear Equipo";
            // 
            // lblNombreEquipo
            // 
            this.lblNombreEquipo.AutoSize = true;
            this.lblNombreEquipo.Location = new System.Drawing.Point(16, 83);
            this.lblNombreEquipo.Name = "lblNombreEquipo";
            this.lblNombreEquipo.Size = new System.Drawing.Size(97, 13);
            this.lblNombreEquipo.TabIndex = 61;
            this.lblNombreEquipo.Text = "Nombre del Equipo";
            // 
            // txtNombreEquipo
            // 
            this.txtNombreEquipo.Location = new System.Drawing.Point(139, 80);
            this.txtNombreEquipo.Name = "txtNombreEquipo";
            this.txtNombreEquipo.Size = new System.Drawing.Size(226, 20);
            this.txtNombreEquipo.TabIndex = 62;
            // 
            // dpbDatosEquipo
            // 
            this.dpbDatosEquipo.Controls.Add(this.btnSubirFoto);
            this.dpbDatosEquipo.Controls.Add(this.pictureBox1);
            this.dpbDatosEquipo.Controls.Add(this.lblLogo);
            this.dpbDatosEquipo.Controls.Add(this.lblDescripcion);
            this.dpbDatosEquipo.Controls.Add(this.txtDescripcion);
            this.dpbDatosEquipo.Controls.Add(this.lblCreador);
            this.dpbDatosEquipo.Controls.Add(this.txtCreador);
            this.dpbDatosEquipo.Controls.Add(this.lblNombreEquipo);
            this.dpbDatosEquipo.Controls.Add(this.txtNombreEquipo);
            this.dpbDatosEquipo.Location = new System.Drawing.Point(33, 67);
            this.dpbDatosEquipo.Name = "dpbDatosEquipo";
            this.dpbDatosEquipo.Size = new System.Drawing.Size(407, 512);
            this.dpbDatosEquipo.TabIndex = 63;
            this.dpbDatosEquipo.TabStop = false;
            this.dpbDatosEquipo.Text = "Datos del Equipo";
            // 
            // btnSubirFoto
            // 
            this.btnSubirFoto.Location = new System.Drawing.Point(243, 330);
            this.btnSubirFoto.Name = "btnSubirFoto";
            this.btnSubirFoto.Size = new System.Drawing.Size(75, 23);
            this.btnSubirFoto.TabIndex = 71;
            this.btnSubirFoto.Text = "Subir Foto";
            this.btnSubirFoto.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(19, 330);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 59);
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(16, 314);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(31, 13);
            this.lblLogo.TabIndex = 69;
            this.lblLogo.Text = "Logo";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(16, 121);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(116, 13);
            this.lblDescripcion.TabIndex = 65;
            this.lblDescripcion.Text = "Descripcion del Equipo";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(139, 118);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(226, 104);
            this.txtDescripcion.TabIndex = 66;
            // 
            // lblCreador
            // 
            this.lblCreador.AutoSize = true;
            this.lblCreador.Location = new System.Drawing.Point(66, 46);
            this.lblCreador.Name = "lblCreador";
            this.lblCreador.Size = new System.Drawing.Size(44, 13);
            this.lblCreador.TabIndex = 63;
            this.lblCreador.Text = "Creador";
            // 
            // txtCreador
            // 
            this.txtCreador.Location = new System.Drawing.Point(139, 43);
            this.txtCreador.Name = "txtCreador";
            this.txtCreador.ReadOnly = true;
            this.txtCreador.Size = new System.Drawing.Size(226, 20);
            this.txtCreador.TabIndex = 64;
            // 
            // btnCrearEquipo
            // 
            this.btnCrearEquipo.Location = new System.Drawing.Point(365, 585);
            this.btnCrearEquipo.Name = "btnCrearEquipo";
            this.btnCrearEquipo.Size = new System.Drawing.Size(75, 23);
            this.btnCrearEquipo.TabIndex = 64;
            this.btnCrearEquipo.Text = "Crear Equipo";
            this.btnCrearEquipo.UseVisualStyleBackColor = true;
            this.btnCrearEquipo.Click += new System.EventHandler(this.btnCrearEquipo_Click);
            // 
            // frmCrearEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 643);
            this.Controls.Add(this.btnCrearEquipo);
            this.Controls.Add(this.dpbDatosEquipo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmCrearEquipo";
            this.Text = "frmCrearEquipo";
            this.Load += new System.EventHandler(this.frmCrearEquipo_Load);
            this.dpbDatosEquipo.ResumeLayout(false);
            this.dpbDatosEquipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombreEquipo;
        private System.Windows.Forms.TextBox txtNombreEquipo;
        private System.Windows.Forms.GroupBox dpbDatosEquipo;
        private System.Windows.Forms.Label lblCreador;
        private System.Windows.Forms.TextBox txtCreador;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnSubirFoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnCrearEquipo;
    }
}