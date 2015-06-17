namespace CentroSaludSantaIsabel
{
    partial class UCHistoriaClinica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCHistoriaClinica));
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.buttonPaciente = new System.Windows.Forms.Button();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelNombres = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFoto.InitialImage")));
            this.pictureBoxFoto.Location = new System.Drawing.Point(13, 10);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(164, 164);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFoto.TabIndex = 157;
            this.pictureBoxFoto.TabStop = false;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(188, 19);
            this.labelDescripcion.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(155, 32);
            this.labelDescripcion.TabIndex = 156;
            this.labelDescripcion.Text = "PACIENTE";
            // 
            // buttonPaciente
            // 
            this.buttonPaciente.Location = new System.Drawing.Point(708, 10);
            this.buttonPaciente.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonPaciente.Name = "buttonPaciente";
            this.buttonPaciente.Size = new System.Drawing.Size(176, 94);
            this.buttonPaciente.TabIndex = 155;
            this.buttonPaciente.Text = "Gestionar";
            this.buttonPaciente.UseVisualStyleBackColor = true;
            this.buttonPaciente.Click += new System.EventHandler(this.buttonPaciente_Click);
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Location = new System.Drawing.Point(188, 96);
            this.labelApellidos.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(141, 32);
            this.labelApellidos.TabIndex = 154;
            this.labelApellidos.Text = "Apellidos:";
            // 
            // labelNombres
            // 
            this.labelNombres.AutoSize = true;
            this.labelNombres.Location = new System.Drawing.Point(188, 52);
            this.labelNombres.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelNombres.Name = "labelNombres";
            this.labelNombres.Size = new System.Drawing.Size(137, 32);
            this.labelNombres.TabIndex = 153;
            this.labelNombres.Text = "Nombres:";
            // 
            // UCHistoriaClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.buttonPaciente);
            this.Controls.Add(this.labelApellidos);
            this.Controls.Add(this.labelNombres);
            this.Name = "UCHistoriaClinica";
            this.Size = new System.Drawing.Size(896, 185);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBoxFoto;
        public System.Windows.Forms.Label labelDescripcion;
        public System.Windows.Forms.Button buttonPaciente;
        public System.Windows.Forms.Label labelApellidos;
        public System.Windows.Forms.Label labelNombres;
        
    }
}
