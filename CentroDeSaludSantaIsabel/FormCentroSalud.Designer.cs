namespace CentroSaludSantaIsabel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCentroSalud));
            this.buttonNuevaHC = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxEntryBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNuevaHC
            // 
            this.buttonNuevaHC.Location = new System.Drawing.Point(1086, 120);
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
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bebas Neue", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(299, 71);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(311, 58);
            this.label7.TabIndex = 156;
            this.label7.Text = "HISTORIAS CLINICAS";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(888, 120);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(179, 65);
            this.buttonBuscar.TabIndex = 159;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxEntryBusqueda
            // 
            this.textBoxEntryBusqueda.Location = new System.Drawing.Point(306, 134);
            this.textBoxEntryBusqueda.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxEntryBusqueda.Name = "textBoxEntryBusqueda";
            this.textBoxEntryBusqueda.Size = new System.Drawing.Size(566, 38);
            this.textBoxEntryBusqueda.TabIndex = 158;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 989);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1560, 80);
            this.label1.TabIndex = 160;
            this.label1.Text = "CENTRO SALUD SANTA ISABEL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseMnemonic = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(306, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(956, 783);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 161;
            this.pictureBox1.TabStop = false;
            // 
            // FormCentroSalud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1585, 1113);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxEntryBusqueda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonNuevaHC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCentroSalud";
            this.Text = "Centro de Salud";
            this.Load += new System.EventHandler(this.FormCentroSalud_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormCentroSalud_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonNuevaHC;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxEntryBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

