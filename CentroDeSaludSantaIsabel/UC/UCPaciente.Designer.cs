namespace CentroSaludSantaIsabel
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
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelNombres = new System.Windows.Forms.Label();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.labelSexo = new System.Windows.Forms.Label();
            this.labelGrupoSanguineo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Bebas Neue", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.Location = new System.Drawing.Point(19, 586);
            this.labelDescripcion.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(227, 80);
            this.labelDescripcion.TabIndex = 150;
            this.labelDescripcion.Text = "PACIENTE";
            // 
            // buttonGestionarPaciente
            // 
            this.buttonGestionarPaciente.BackColor = System.Drawing.Color.Transparent;
            this.buttonGestionarPaciente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGestionarPaciente.BackgroundImage")));
            this.buttonGestionarPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGestionarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestionarPaciente.Location = new System.Drawing.Point(461, 586);
            this.buttonGestionarPaciente.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonGestionarPaciente.Name = "buttonGestionarPaciente";
            this.buttonGestionarPaciente.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonGestionarPaciente.Size = new System.Drawing.Size(89, 88);
            this.buttonGestionarPaciente.TabIndex = 149;
            this.buttonGestionarPaciente.UseVisualStyleBackColor = false;
            this.buttonGestionarPaciente.Click += new System.EventHandler(this.buttonGestionarPaciente_Click);
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Font = new System.Drawing.Font("Calibri", 14.1F);
            this.labelApellidos.Location = new System.Drawing.Point(23, 715);
            this.labelApellidos.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(204, 59);
            this.labelApellidos.TabIndex = 148;
            this.labelApellidos.Text = "Apellidos";
            // 
            // labelNombres
            // 
            this.labelNombres.AutoSize = true;
            this.labelNombres.Font = new System.Drawing.Font("Calibri", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombres.Location = new System.Drawing.Point(23, 656);
            this.labelNombres.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelNombres.Name = "labelNombres";
            this.labelNombres.Size = new System.Drawing.Size(203, 59);
            this.labelNombres.TabIndex = 147;
            this.labelNombres.Text = "Nombres";
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFoto.BackgroundImage")));
            this.pictureBoxFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFoto.InitialImage")));
            this.pictureBoxFoto.Location = new System.Drawing.Point(17, 13);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(559, 508);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFoto.TabIndex = 151;
            this.pictureBoxFoto.TabStop = false;
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Font = new System.Drawing.Font("Calibri", 14.1F);
            this.labelSexo.Location = new System.Drawing.Point(32, 833);
            this.labelSexo.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(115, 59);
            this.labelSexo.TabIndex = 153;
            this.labelSexo.Text = "Sexo";
            // 
            // labelGrupoSanguineo
            // 
            this.labelGrupoSanguineo.AutoSize = true;
            this.labelGrupoSanguineo.Font = new System.Drawing.Font("Calibri", 14.1F);
            this.labelGrupoSanguineo.Location = new System.Drawing.Point(23, 774);
            this.labelGrupoSanguineo.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelGrupoSanguineo.Name = "labelGrupoSanguineo";
            this.labelGrupoSanguineo.Size = new System.Drawing.Size(361, 59);
            this.labelGrupoSanguineo.TabIndex = 154;
            this.labelGrupoSanguineo.Text = "Grupo Sanguineo";
            // 
            // UCPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.labelGrupoSanguineo);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.buttonGestionarPaciente);
            this.Controls.Add(this.labelApellidos);
            this.Controls.Add(this.labelNombres);
            this.Name = "UCPaciente";
            this.Size = new System.Drawing.Size(588, 915);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBoxFoto;
        public System.Windows.Forms.Label labelDescripcion;
        public System.Windows.Forms.Button buttonGestionarPaciente;
        public System.Windows.Forms.Label labelApellidos;
        public System.Windows.Forms.Label labelNombres;
        public System.Windows.Forms.Label labelSexo;
        public System.Windows.Forms.Label labelGrupoSanguineo;
    }
}
