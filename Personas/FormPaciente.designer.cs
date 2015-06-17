namespace Personas
{
    partial class FormPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPaciente));
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.comboBoxGrupoSanguineo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxFactorRH = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxIdiomaMaterno = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label_titulo = new System.Windows.Forms.Label();
            this.textBoxEstadoCivil = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxOcupacion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxNacionalidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(746, 667);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(183, 61);
            this.buttonGuardar.TabIndex = 0;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(290, 66);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(260, 38);
            this.textBoxNombre.TabIndex = 2;
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(290, 175);
            this.textBoxApellidos.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(260, 38);
            this.textBoxApellidos.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 297);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(659, 297);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sexo";
            // 
            // dateTimePickerFechaNacimiento
            // 
            this.dateTimePickerFechaNacimiento.Location = new System.Drawing.Point(21, 336);
            this.dateTimePickerFechaNacimiento.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            this.dateTimePickerFechaNacimiento.Size = new System.Drawing.Size(581, 38);
            this.dateTimePickerFechaNacimiento.TabIndex = 11;
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.comboBoxSexo.Location = new System.Drawing.Point(667, 342);
            this.comboBoxSexo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(262, 39);
            this.comboBoxSexo.TabIndex = 26;
            // 
            // comboBoxGrupoSanguineo
            // 
            this.comboBoxGrupoSanguineo.FormattingEnabled = true;
            this.comboBoxGrupoSanguineo.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "O"});
            this.comboBoxGrupoSanguineo.Location = new System.Drawing.Point(342, 572);
            this.comboBoxGrupoSanguineo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBoxGrupoSanguineo.Name = "comboBoxGrupoSanguineo";
            this.comboBoxGrupoSanguineo.Size = new System.Drawing.Size(260, 39);
            this.comboBoxGrupoSanguineo.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(334, 526);
            this.label14.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(239, 32);
            this.label14.TabIndex = 31;
            this.label14.Text = "Grupo Sanguineo";
            // 
            // comboBoxFactorRH
            // 
            this.comboBoxFactorRH.FormattingEnabled = true;
            this.comboBoxFactorRH.Items.AddRange(new object[] {
            "Positivo",
            "Negativo"});
            this.comboBoxFactorRH.Location = new System.Drawing.Point(667, 572);
            this.comboBoxFactorRH.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBoxFactorRH.Name = "comboBoxFactorRH";
            this.comboBoxFactorRH.Size = new System.Drawing.Size(262, 39);
            this.comboBoxFactorRH.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(659, 526);
            this.label15.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 32);
            this.label15.TabIndex = 33;
            this.label15.Text = "Factor RH";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(741, 27);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(183, 62);
            this.buttonBuscar.TabIndex = 37;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 533);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 32);
            this.label9.TabIndex = 18;
            this.label9.Text = "Idioma Materno";
            // 
            // textBoxIdiomaMaterno
            // 
            this.textBoxIdiomaMaterno.Location = new System.Drawing.Point(24, 572);
            this.textBoxIdiomaMaterno.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxIdiomaMaterno.Name = "textBoxIdiomaMaterno";
            this.textBoxIdiomaMaterno.Size = new System.Drawing.Size(260, 38);
            this.textBoxIdiomaMaterno.TabIndex = 19;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(24, 667);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(183, 61);
            this.buttonCancelar.TabIndex = 38;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // label_titulo
            // 
            this.label_titulo.Location = new System.Drawing.Point(232, 793);
            this.label_titulo.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(482, 80);
            this.label_titulo.TabIndex = 135;
            this.label_titulo.Text = "CENTRO SALUD SANTA ISABEL";
            this.label_titulo.UseMnemonic = false;
            // 
            // textBoxEstadoCivil
            // 
            this.textBoxEstadoCivil.Location = new System.Drawing.Point(667, 455);
            this.textBoxEstadoCivil.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxEstadoCivil.Name = "textBoxEstadoCivil";
            this.textBoxEstadoCivil.Size = new System.Drawing.Size(262, 38);
            this.textBoxEstadoCivil.TabIndex = 173;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(659, 417);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 32);
            this.label5.TabIndex = 172;
            this.label5.Text = "Estado Civil";
            // 
            // textBoxOcupacion
            // 
            this.textBoxOcupacion.Location = new System.Drawing.Point(340, 455);
            this.textBoxOcupacion.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxOcupacion.Name = "textBoxOcupacion";
            this.textBoxOcupacion.Size = new System.Drawing.Size(260, 38);
            this.textBoxOcupacion.TabIndex = 171;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(334, 417);
            this.label12.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 32);
            this.label12.TabIndex = 170;
            this.label12.Text = "Ocupacion";
            // 
            // textBoxNacionalidad
            // 
            this.textBoxNacionalidad.Location = new System.Drawing.Point(26, 455);
            this.textBoxNacionalidad.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxNacionalidad.Name = "textBoxNacionalidad";
            this.textBoxNacionalidad.Size = new System.Drawing.Size(258, 38);
            this.textBoxNacionalidad.TabIndex = 169;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 416);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 32);
            this.label6.TabIndex = 168;
            this.label6.Text = "Nacionalidad";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 174;
            this.pictureBox1.TabStop = false;
            // 
            // FormPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(967, 906);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxEstadoCivil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxOcupacion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxNacionalidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.comboBoxFactorRH);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBoxGrupoSanguineo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBoxSexo);
            this.Controls.Add(this.textBoxIdiomaMaterno);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePickerFechaNacimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxApellidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGuardar);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FormPaciente";
            this.Text = "Paciente";
            this.Load += new System.EventHandler(this.Paciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label label1;
       
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox comboBoxSexo;
        public System.Windows.Forms.ComboBox comboBoxGrupoSanguineo;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.ComboBox comboBoxFactorRH;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxNombre;
        public System.Windows.Forms.TextBox textBoxApellidos;
        public System.Windows.Forms.TextBox textBoxIdiomaMaterno;
        public System.Windows.Forms.TextBox textBoxOcupacion;
        public System.Windows.Forms.TextBox textBoxNacionalidad;
        public System.Windows.Forms.TextBox textBoxEstadoCivil;
        public System.Windows.Forms.DateTimePicker dateTimePickerFechaNacimiento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}