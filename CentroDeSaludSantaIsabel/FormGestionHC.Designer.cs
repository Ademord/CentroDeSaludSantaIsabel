namespace CentroSaludSantaIsabel
{
    partial class FormGestionHC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionHC));
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.AutoSize = true;
            this.buttonNuevo.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonNuevo.Font = new System.Drawing.Font("Bebas Neue", 14.1F);
            this.buttonNuevo.Location = new System.Drawing.Point(0, 0);
            this.buttonNuevo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(179, 154);
            this.buttonNuevo.TabIndex = 160;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonGuardar.Font = new System.Drawing.Font("Bebas Neue", 14.1F);
            this.buttonGuardar.Location = new System.Drawing.Point(742, 0);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(331, 154);
            this.buttonGuardar.TabIndex = 164;
            this.buttonGuardar.Text = "Guardar Cambios";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // buttonCargar
            // 
            this.buttonCargar.AutoSize = true;
            this.buttonCargar.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonCargar.Font = new System.Drawing.Font("Bebas Neue", 14.1F);
            this.buttonCargar.Location = new System.Drawing.Point(179, 0);
            this.buttonCargar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Padding = new System.Windows.Forms.Padding(5);
            this.buttonCargar.Size = new System.Drawing.Size(202, 154);
            this.buttonCargar.TabIndex = 165;
            this.buttonCargar.Text = "Cargar";
            this.buttonCargar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCargar);
            this.panel1.Controls.Add(this.buttonNuevo);
            this.panel1.Controls.Add(this.buttonGuardar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 154);
            this.panel1.TabIndex = 166;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1073, 876);
            this.panel2.TabIndex = 167;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel.BackgroundImage")));
            this.flowLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(1073, 876);
            this.flowLayoutPanel.TabIndex = 163;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 1030);
            this.panel3.TabIndex = 168;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(210, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1073, 1030);
            this.panel4.TabIndex = 169;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1283, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(210, 1030);
            this.panel5.TabIndex = 170;
            // 
            // FormGestionHC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1493, 1030);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Name = "FormGestionHC";
            this.Text = "FormGestion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}