namespace CentroDeSaludSantaIsabel
{
    partial class UCPaciente
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPaciente));
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.buttonGestionarPaciente = new System.Windows.Forms.Button();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.labelGrupoSanguineo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(192, 22);
            this.labelDescripcion.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(155, 32);
            this.labelDescripcion.TabIndex = 150;
            this.labelDescripcion.Text = "PACIENTE";
            // 
            // buttonGestionarPaciente
            // 
            this.buttonGestionarPaciente.Location = new System.Drawing.Point(1315, 13);
            this.buttonGestionarPaciente.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonGestionarPaciente.Name = "buttonGestionarPaciente";
            this.buttonGestionarPaciente.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonGestionarPaciente.Size = new System.Drawing.Size(176, 94);
            this.buttonGestionarPaciente.TabIndex = 149;
            this.buttonGestionarPaciente.Text = "Gestionar";
            this.buttonGestionarPaciente.UseVisualStyleBackColor = true;
            this.buttonGestionarPaciente.Click += new System.EventHandler(this.buttonGestionarPaciente_Click);
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(192, 99);
            this.labelApellido.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(133, 32);
            this.labelApellido.TabIndex = 148;
            this.labelApellido.Text = "Apellidos";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(192, 55);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(129, 32);
            this.labelNombre.TabIndex = 147;
            this.labelNombre.Text = "Nombres";
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFoto.Image = global::CentroDeSaludSantaIsabel.Properties.Resources.default_user_icon;
            this.pictureBoxFoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFoto.InitialImage")));
            this.pictureBoxFoto.Location = new System.Drawing.Point(17, 13);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(164, 164);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFoto.TabIndex = 151;
            this.pictureBoxFoto.TabStop = false;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(641, 55);
            this.labelTelefono.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(127, 32);
            this.labelTelefono.TabIndex = 152;
            this.labelTelefono.Text = "Telefono";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(641, 99);
            this.labelSexo.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(80, 32);
            this.labelSexo.TabIndex = 153;
            this.labelSexo.Text = "Sexo";
            // 
            // labelGrupoSanguineo
            // 
            this.labelGrupoSanguineo.AutoSize = true;
            this.labelGrupoSanguineo.Location = new System.Drawing.Point(945, 55);
            this.labelGrupoSanguineo.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelGrupoSanguineo.Name = "labelGrupoSanguineo";
            this.labelGrupoSanguineo.Size = new System.Drawing.Size(239, 32);
            this.labelGrupoSanguineo.TabIndex = 154;
            this.labelGrupoSanguineo.Text = "Grupo Sanguineo";
            // 
            // UCPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.labelGrupoSanguineo);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.buttonGestionarPaciente);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Name = "UCPaciente";
            this.Size = new System.Drawing.Size(1503, 185);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBoxFoto;
        public System.Windows.Forms.Label labelDescripcion;
        public System.Windows.Forms.Button buttonGestionarPaciente;
        public System.Windows.Forms.Label labelApellido;
        public System.Windows.Forms.Label labelNombre;
        public System.Windows.Forms.Label labelTelefono;
        public System.Windows.Forms.Label labelSexo;
        public System.Windows.Forms.Label labelGrupoSanguineo;
    }
}
