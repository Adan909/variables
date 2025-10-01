namespace variables.Formularios
{
    partial class FrmArreglo
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
            this.gbEdades = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.lbEdades = new System.Windows.Forms.ListBox();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblMayor = new System.Windows.Forms.Label();
            this.lblMenor = new System.Windows.Forms.Label();
            this.gbEdades.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEdades
            // 
            this.gbEdades.Controls.Add(this.lblMenor);
            this.gbEdades.Controls.Add(this.lblMayor);
            this.gbEdades.Controls.Add(this.lblPromedio);
            this.gbEdades.Controls.Add(this.lbEdades);
            this.gbEdades.Controls.Add(this.tbEdad);
            this.gbEdades.Controls.Add(this.label1);
            this.gbEdades.Location = new System.Drawing.Point(55, 13);
            this.gbEdades.Name = "gbEdades";
            this.gbEdades.Size = new System.Drawing.Size(178, 339);
            this.gbEdades.TabIndex = 0;
            this.gbEdades.TabStop = false;
            this.gbEdades.Text = "Edades: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la Edad";
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(10, 62);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(138, 20);
            this.tbEdad.TabIndex = 1;
            this.tbEdad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEdad_KeyDown);
            // 
            // lbEdades
            // 
            this.lbEdades.FormattingEnabled = true;
            this.lbEdades.Location = new System.Drawing.Point(6, 88);
            this.lbEdades.Name = "lbEdades";
            this.lbEdades.Size = new System.Drawing.Size(152, 160);
            this.lbEdades.TabIndex = 2;
            // 
            // lblPromedio
            // 
            this.lblPromedio.Location = new System.Drawing.Point(7, 255);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(100, 23);
            this.lblPromedio.TabIndex = 3;
            this.lblPromedio.Text = "Promedio: 0";
            // 
            // lblMayor
            // 
            this.lblMayor.Location = new System.Drawing.Point(7, 278);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(100, 23);
            this.lblMayor.TabIndex = 4;
            this.lblMayor.Text = "Mayor: 0";
            // 
            // lblMenor
            // 
            this.lblMenor.Location = new System.Drawing.Point(7, 301);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(100, 23);
            this.lblMenor.TabIndex = 5;
            this.lblMenor.Text = "Menor: 0";
            // 
            // FrmArreglo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbEdades);
            this.MaximizeBox = false;
            this.Name = "FrmArreglo";
            this.Text = "Arreglos";
            this.gbEdades.ResumeLayout(false);
            this.gbEdades.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEdades;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.ListBox lbEdades;
        private System.Windows.Forms.Label lblMenor;
        private System.Windows.Forms.Label lblMayor;
    }
}