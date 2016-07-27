namespace WindowsDemo
{
    partial class FormFaehre
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonFahrzeugeAufnehmen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonFaehreErzeugen = new System.Windows.Forms.Button();
            this.textBoxFaehreLaenge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFaehreBaujahr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFaehreName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMeldung = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFahrzeugeAufnehmen
            // 
            this.buttonFahrzeugeAufnehmen.Location = new System.Drawing.Point(405, 148);
            this.buttonFahrzeugeAufnehmen.Name = "buttonFahrzeugeAufnehmen";
            this.buttonFahrzeugeAufnehmen.Size = new System.Drawing.Size(75, 23);
            this.buttonFahrzeugeAufnehmen.TabIndex = 0;
            this.buttonFahrzeugeAufnehmen.Text = "button1";
            this.buttonFahrzeugeAufnehmen.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.buttonFaehreErzeugen);
            this.groupBox1.Controls.Add(this.textBoxFaehreLaenge);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxFaehreBaujahr);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxFaehreName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 228);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fähre Daten";
            // 
            // buttonFaehreErzeugen
            // 
            this.buttonFaehreErzeugen.BackColor = System.Drawing.Color.Red;
            this.buttonFaehreErzeugen.Location = new System.Drawing.Point(22, 172);
            this.buttonFaehreErzeugen.Name = "buttonFaehreErzeugen";
            this.buttonFaehreErzeugen.Size = new System.Drawing.Size(192, 24);
            this.buttonFaehreErzeugen.TabIndex = 6;
            this.buttonFaehreErzeugen.Text = "Fähre erzeugen";
            this.buttonFaehreErzeugen.UseVisualStyleBackColor = false;
            this.buttonFaehreErzeugen.Click += new System.EventHandler(this.buttonFaehreErzeugen_Click);
            // 
            // textBoxFaehreLaenge
            // 
            this.textBoxFaehreLaenge.Location = new System.Drawing.Point(92, 119);
            this.textBoxFaehreLaenge.Name = "textBoxFaehreLaenge";
            this.textBoxFaehreLaenge.Size = new System.Drawing.Size(122, 20);
            this.textBoxFaehreLaenge.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Länge";
            // 
            // textBoxFaehreBaujahr
            // 
            this.textBoxFaehreBaujahr.Location = new System.Drawing.Point(92, 73);
            this.textBoxFaehreBaujahr.Name = "textBoxFaehreBaujahr";
            this.textBoxFaehreBaujahr.Size = new System.Drawing.Size(122, 20);
            this.textBoxFaehreBaujahr.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baujahr";
            // 
            // textBoxFaehreName
            // 
            this.textBoxFaehreName.Location = new System.Drawing.Point(92, 24);
            this.textBoxFaehreName.Name = "textBoxFaehreName";
            this.textBoxFaehreName.Size = new System.Drawing.Size(122, 20);
            this.textBoxFaehreName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMeldung});
            this.statusStrip1.Location = new System.Drawing.Point(0, 488);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(537, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMeldung
            // 
            this.toolStripStatusLabelMeldung.Name = "toolStripStatusLabelMeldung";
            this.toolStripStatusLabelMeldung.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabelMeldung.Text = "toolStripStatusLabel1";
            // 
            // FormFaehre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 510);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonFahrzeugeAufnehmen);
            this.Name = "FormFaehre";
            this.Text = "Fahrzeuge aufnehmen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFahrzeugeAufnehmen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonFaehreErzeugen;
        private System.Windows.Forms.TextBox textBoxFaehreLaenge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFaehreBaujahr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFaehreName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMeldung;
    }
}

