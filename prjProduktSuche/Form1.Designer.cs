namespace prjProduktSuche
{
    partial class Form1
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
            this.btnSuche = new System.Windows.Forms.Button();
            this.tbEingabefeld = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnDurchsuchen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSuche
            // 
            this.btnSuche.Location = new System.Drawing.Point(347, 446);
            this.btnSuche.Name = "btnSuche";
            this.btnSuche.Size = new System.Drawing.Size(75, 23);
            this.btnSuche.TabIndex = 1;
            this.btnSuche.Text = "Suche";
            this.btnSuche.UseVisualStyleBackColor = true;
            this.btnSuche.Click += new System.EventHandler(this.btnSuche_Click);
            // 
            // tbEingabefeld
            // 
            this.tbEingabefeld.Location = new System.Drawing.Point(50, 449);
            this.tbEingabefeld.Name = "tbEingabefeld";
            this.tbEingabefeld.Size = new System.Drawing.Size(232, 20);
            this.tbEingabefeld.TabIndex = 2;
            this.tbEingabefeld.TextChanged += new System.EventHandler(this.tbEingabefeld_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(50, 147);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(838, 216);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // btnDurchsuchen
            // 
            this.btnDurchsuchen.Location = new System.Drawing.Point(50, 68);
            this.btnDurchsuchen.Name = "btnDurchsuchen";
            this.btnDurchsuchen.Size = new System.Drawing.Size(131, 23);
            this.btnDurchsuchen.TabIndex = 4;
            this.btnDurchsuchen.Text = "PDFs Durchsuchen";
            this.btnDurchsuchen.UseVisualStyleBackColor = true;
            this.btnDurchsuchen.Click += new System.EventHandler(this.btnDurchsuchen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 544);
            this.Controls.Add(this.btnDurchsuchen);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tbEingabefeld);
            this.Controls.Add(this.btnSuche);
            this.Name = "Form1";
            this.Text = "Produktsuche";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSuche;
        private System.Windows.Forms.TextBox tbEingabefeld;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnDurchsuchen;
    }
}

