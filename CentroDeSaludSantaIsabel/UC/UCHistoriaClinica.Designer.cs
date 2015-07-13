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
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFoto.BackgroundImage")));
            this.pictureBoxFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxFoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFoto.InitialImage")));
            this.pictureBoxFoto.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(271, 266);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFoto.TabIndex = 157;
            this.pictureBoxFoto.TabStop = false;
            this.pictureBoxFoto.MouseLeave += new System.EventHandler(this.pictureBoxFoto_MouseLeave);
            this.pictureBoxFoto.MouseHover += new System.EventHandler(this.pictureBoxFoto_MouseHover);
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelDescripcion.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.Location = new System.Drawing.Point(8, 0);
            this.labelDescripcion.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(201, 80);
            this.labelDescripcion.TabIndex = 156;
            this.labelDescripcion.Text = "PACIENTE";
            this.labelDescripcion.MouseLeave += new System.EventHandler(this.labelDescripcion_MouseLeave);
            this.labelDescripcion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelDescripcion_MouseMove);
            // 
            // buttonPaciente
            // 
            this.buttonPaciente.BackColor = System.Drawing.Color.Transparent;
            this.buttonPaciente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPaciente.BackgroundImage")));
            this.buttonPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPaciente.Font = new System.Drawing.Font("Bebas Neue", 14.1F);
            this.buttonPaciente.Location = new System.Drawing.Point(225, 7);
            this.buttonPaciente.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonPaciente.Name = "buttonPaciente";
            this.buttonPaciente.Size = new System.Drawing.Size(61, 66);
            this.buttonPaciente.TabIndex = 155;
            this.buttonPaciente.UseVisualStyleBackColor = false;
            this.buttonPaciente.Click += new System.EventHandler(this.buttonPaciente_Click);
            this.buttonPaciente.MouseLeave += new System.EventHandler(this.buttonPaciente_MouseLeave);
            this.buttonPaciente.MouseHover += new System.EventHandler(this.buttonPaciente_MouseHover);
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Font = new System.Drawing.Font("Calibri", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidos.Location = new System.Drawing.Point(8, 59);
            this.labelApellidos.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(217, 59);
            this.labelApellidos.TabIndex = 154;
            this.labelApellidos.Text = "Apellidos:";
            this.labelApellidos.MouseLeave += new System.EventHandler(this.labelApellidos_MouseLeave);
            this.labelApellidos.MouseHover += new System.EventHandler(this.labelApellidos_MouseHover);
            // 
            // labelNombres
            // 
            this.labelNombres.AutoSize = true;
            this.labelNombres.Font = new System.Drawing.Font("Calibri", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombres.Location = new System.Drawing.Point(8, 0);
            this.labelNombres.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelNombres.Name = "labelNombres";
            this.labelNombres.Size = new System.Drawing.Size(216, 59);
            this.labelNombres.TabIndex = 153;
            this.labelNombres.Text = "Nombres:";
            this.labelNombres.MouseLeave += new System.EventHandler(this.labelNombres_MouseLeave);
            this.labelNombres.MouseHover += new System.EventHandler(this.labelNombres_MouseHover);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.Transparent;
            this.buttonEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEliminar.BackgroundImage")));
            this.buttonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Bebas Neue", 14.1F);
            this.buttonEliminar.Location = new System.Drawing.Point(302, 7);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(69, 66);
            this.buttonEliminar.TabIndex = 158;
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            this.buttonEliminar.MouseLeave += new System.EventHandler(this.buttonEliminar_MouseLeave);
            this.buttonEliminar.MouseHover += new System.EventHandler(this.buttonEliminar_MouseHover);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.labelDescripcion);
            this.flowLayoutPanel1.Controls.Add(this.buttonPaciente);
            this.flowLayoutPanel1.Controls.Add(this.buttonEliminar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(271, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(625, 91);
            this.flowLayoutPanel1.TabIndex = 159;
            this.flowLayoutPanel1.MouseLeave += new System.EventHandler(this.flowLayoutPanel1_MouseLeave);
            this.flowLayoutPanel1.MouseHover += new System.EventHandler(this.flowLayoutPanel1_MouseHover);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.labelNombres);
            this.flowLayoutPanel2.Controls.Add(this.labelApellidos);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(271, 91);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(625, 175);
            this.flowLayoutPanel2.TabIndex = 160;
            this.flowLayoutPanel2.MouseLeave += new System.EventHandler(this.flowLayoutPanel2_MouseLeave);
            this.flowLayoutPanel2.MouseHover += new System.EventHandler(this.flowLayoutPanel2_MouseHover);
            // 
            // UCHistoriaClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBoxFoto);
            this.Name = "UCHistoriaClinica";
            this.Size = new System.Drawing.Size(896, 266);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public int index_paciente = CONFIG.NEW_REG;
        public System.Windows.Forms.PictureBox pictureBoxFoto;
        public System.Windows.Forms.Label labelDescripcion;
        public System.Windows.Forms.Button buttonPaciente;
        public System.Windows.Forms.Label labelApellidos;
        public System.Windows.Forms.Label labelNombres;
        public System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        
    }
}
