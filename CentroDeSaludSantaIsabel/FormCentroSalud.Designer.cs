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
            System.Windows.Forms.Button buttonSalir;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCentroSalud));
            this.buttonPacientes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSalud = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelDesk = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            buttonSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSalir
            // 
            buttonSalir.AutoSize = true;
            buttonSalir.BackColor = System.Drawing.Color.Firebrick;
            buttonSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonSalir.Font = new System.Drawing.Font("Bebas Neue", 14.1F);
            buttonSalir.ForeColor = System.Drawing.Color.WhiteSmoke;
            buttonSalir.Location = new System.Drawing.Point(0, 0);
            buttonSalir.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new System.Drawing.Size(218, 177);
            buttonSalir.TabIndex = 166;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonPacientes
            // 
            this.buttonPacientes.AutoSize = true;
            this.buttonPacientes.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPacientes.Font = new System.Drawing.Font("Bebas Neue", 14.1F);
            this.buttonPacientes.Location = new System.Drawing.Point(0, 0);
            this.buttonPacientes.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonPacientes.Name = "buttonPacientes";
            this.buttonPacientes.Size = new System.Drawing.Size(201, 168);
            this.buttonPacientes.TabIndex = 148;
            this.buttonPacientes.Text = "Pacientes";
            this.buttonPacientes.UseVisualStyleBackColor = true;
            this.buttonPacientes.Click += new System.EventHandler(this.buttonPacientes_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 1117);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1980, 80);
            this.label1.TabIndex = 160;
            this.label1.Text = "CENTRO SALUD SANTA ISABEL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseMnemonic = false;
            // 
            // buttonSalud
            // 
            this.buttonSalud.AutoSize = true;
            this.buttonSalud.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSalud.Font = new System.Drawing.Font("Bebas Neue", 14.1F);
            this.buttonSalud.Location = new System.Drawing.Point(201, 0);
            this.buttonSalud.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonSalud.Name = "buttonSalud";
            this.buttonSalud.Padding = new System.Windows.Forms.Padding(15);
            this.buttonSalud.Size = new System.Drawing.Size(201, 168);
            this.buttonSalud.TabIndex = 162;
            this.buttonSalud.Text = "Salud";
            this.buttonSalud.UseVisualStyleBackColor = true;
            this.buttonSalud.Click += new System.EventHandler(this.buttonSalud_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Font = new System.Drawing.Font("Bebas Neue", 14.1F);
            this.button2.Location = new System.Drawing.Point(402, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 168);
            this.button2.TabIndex = 163;
            this.button2.Text = "Personal";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.Font = new System.Drawing.Font("Bebas Neue", 14.1F);
            this.button3.Location = new System.Drawing.Point(616, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(249, 168);
            this.button3.TabIndex = 164;
            this.button3.Text = "Reportes";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1980, 177);
            this.panel1.TabIndex = 167;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.buttonSalud);
            this.panel2.Controls.Add(this.buttonPacientes);
            this.panel2.Location = new System.Drawing.Point(555, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(871, 168);
            this.panel2.TabIndex = 167;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(buttonSalir);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1762, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 177);
            this.panel3.TabIndex = 168;
            // 
            // panelDesk
            // 
            this.panelDesk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelDesk.BackgroundImage")));
            this.panelDesk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelDesk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesk.Location = new System.Drawing.Point(0, 177);
            this.panelDesk.Name = "panelDesk";
            this.panelDesk.Size = new System.Drawing.Size(1980, 940);
            this.panelDesk.TabIndex = 168;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(201, 1197);
            this.panel4.TabIndex = 169;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panelDesk);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(201, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1980, 1197);
            this.panel5.TabIndex = 170;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(2181, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(201, 1197);
            this.panel6.TabIndex = 171;
            // 
            // FormCentroSalud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(2382, 1197);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCentroSalud";
            this.Text = "Centro de Salud";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormCentroSalud_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPacientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSalud;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDesk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}

