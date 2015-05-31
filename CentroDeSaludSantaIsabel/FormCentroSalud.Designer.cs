namespace CentroDeSaludSantaIsabel
{
    partial class FormCentroSalud
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
            this.buttonNuevaHC = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button15 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ucHistoriaClinica1 = new CentroDeSaludSantaIsabel.UCHistoriaClinica();
            this.ucHistoriaClinica2 = new CentroDeSaludSantaIsabel.UCHistoriaClinica();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNuevaHC
            // 
            this.buttonNuevaHC.Location = new System.Drawing.Point(810, 46);
            this.buttonNuevaHC.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonNuevaHC.Name = "buttonNuevaHC";
            this.buttonNuevaHC.Size = new System.Drawing.Size(179, 65);
            this.buttonNuevaHC.TabIndex = 148;
            this.buttonNuevaHC.Text = "Nueva";
            this.buttonNuevaHC.UseVisualStyleBackColor = true;
            this.buttonNuevaHC.Click += new System.EventHandler(this.buttonNuevaHC_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 32);
            this.label7.TabIndex = 156;
            this.label7.Text = "PACIENTE";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.ucHistoriaClinica1);
            this.flowLayoutPanel1.Controls.Add(this.ucHistoriaClinica2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(33, 121);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(956, 770);
            this.flowLayoutPanel1.TabIndex = 157;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(615, 46);
            this.button15.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(179, 65);
            this.button15.TabIndex = 159;
            this.button15.Text = "Buscar";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(33, 60);
            this.textBox7.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(566, 38);
            this.textBox7.TabIndex = 158;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(276, 937);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 80);
            this.label1.TabIndex = 160;
            this.label1.Text = "CENTRO SALUD SANTA ISABEL";
            this.label1.UseMnemonic = false;
            // 
            // ucHistoriaClinica1
            // 
            this.ucHistoriaClinica1.Location = new System.Drawing.Point(3, 3);
            this.ucHistoriaClinica1.Name = "ucHistoriaClinica1";
            this.ucHistoriaClinica1.Size = new System.Drawing.Size(896, 185);
            this.ucHistoriaClinica1.TabIndex = 0;
            // 
            // ucHistoriaClinica2
            // 
            this.ucHistoriaClinica2.Location = new System.Drawing.Point(3, 194);
            this.ucHistoriaClinica2.Name = "ucHistoriaClinica2";
            this.ucHistoriaClinica2.Size = new System.Drawing.Size(896, 185);
            this.ucHistoriaClinica2.TabIndex = 1;
            // 
            // CentroSalud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1041, 1026);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonNuevaHC);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CentroSalud";
            this.Text = "Centro de Salud";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonNuevaHC;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label1;
        private UCHistoriaClinica ucHistoriaClinica1;
        private UCHistoriaClinica ucHistoriaClinica2;
    }
}

