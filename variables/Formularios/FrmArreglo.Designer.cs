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
            this.lblMenor = new System.Windows.Forms.Label();
            this.lblMayor = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lbEdades = new System.Windows.Forms.ListBox();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMayores = new System.Windows.Forms.Label();
            this.lblMenores = new System.Windows.Forms.Label();
            this.gbEdades.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEdades
            // 
            this.gbEdades.Controls.Add(this.lblMenores);
            this.gbEdades.Controls.Add(this.lblMayores);
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
            // lblMenor
            // 
            this.lblMenor.Location = new System.Drawing.Point(7, 276);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(100, 23);
            this.lblMenor.TabIndex = 5;
            this.lblMenor.Text = "Menor: 0";
            // 
            // lblMayor
            // 
            this.lblMayor.Location = new System.Drawing.Point(7, 253);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(100, 23);
            this.lblMayor.TabIndex = 4;
            this.lblMayor.Text = "Mayor: 0";
            // 
            // lblPromedio
            // 
            this.lblPromedio.Location = new System.Drawing.Point(6, 230);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(100, 23);
            this.lblPromedio.TabIndex = 3;
            this.lblPromedio.Text = "Promedio: 0";
            // 
            // lbEdades
            // 
            this.lbEdades.FormattingEnabled = true;
            this.lbEdades.Location = new System.Drawing.Point(6, 67);
            this.lbEdades.Name = "lbEdades";
            this.lbEdades.Size = new System.Drawing.Size(152, 160);
            this.lbEdades.TabIndex = 2;
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(6, 41);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(138, 20);
            this.tbEdad.TabIndex = 1;
            this.tbEdad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEdad_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la Edad";
            // 
            // lblMayores
            // 
            this.lblMayores.AutoSize = true;
            this.lblMayores.Location = new System.Drawing.Point(7, 299);
            this.lblMayores.Name = "lblMayores";
            this.lblMayores.Size = new System.Drawing.Size(95, 13);
            this.lblMayores.TabIndex = 6;
            this.lblMayores.Text = "Mayores de edad: ";
            // 
            // lblMenores
            // 
            this.lblMenores.AutoSize = true;
            this.lblMenores.Location = new System.Drawing.Point(6, 323);
            this.lblMenores.Name = "lblMenores";
            this.lblMenores.Size = new System.Drawing.Size(96, 13);
            this.lblMenores.TabIndex = 7;
            this.lblMenores.Text = "Menores de edad: ";
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
        private System.Windows.Forms.Label lblMenores;
        private System.Windows.Forms.Label lblMayores;
    }
}