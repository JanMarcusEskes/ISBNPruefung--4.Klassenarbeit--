namespace ISBNPruefung
{
    partial class ISBNPruef
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
      this.label1 = new System.Windows.Forms.Label();
      this.txtZahlenfolge = new System.Windows.Forms.TextBox();
      this.txtAusgPruefZiffer = new System.Windows.Forms.TextBox();
      this.txtAusgSumme = new System.Windows.Forms.TextBox();
      this.txtAusgProdukte = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.btnEingabeKorrekt = new System.Windows.Forms.Button();
      this.btnPruefziffer = new System.Windows.Forms.Button();
      this.txtISBN = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.btnISBNCheck = new System.Windows.Forms.Button();
      this.label7 = new System.Windows.Forms.Label();
      this.txtISBNVollst = new System.Windows.Forms.TextBox();
      this.txtPZ = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(49, 60);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(49, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "ISBN-Nr:";
      // 
      // txtZahlenfolge
      // 
      this.txtZahlenfolge.Location = new System.Drawing.Point(104, 31);
      this.txtZahlenfolge.Name = "txtZahlenfolge";
      this.txtZahlenfolge.Size = new System.Drawing.Size(180, 20);
      this.txtZahlenfolge.TabIndex = 1;
      // 
      // txtAusgPruefZiffer
      // 
      this.txtAusgPruefZiffer.Location = new System.Drawing.Point(104, 136);
      this.txtAusgPruefZiffer.Name = "txtAusgPruefZiffer";
      this.txtAusgPruefZiffer.Size = new System.Drawing.Size(180, 20);
      this.txtAusgPruefZiffer.TabIndex = 2;
      // 
      // txtAusgSumme
      // 
      this.txtAusgSumme.Enabled = false;
      this.txtAusgSumme.Location = new System.Drawing.Point(104, 109);
      this.txtAusgSumme.Name = "txtAusgSumme";
      this.txtAusgSumme.Size = new System.Drawing.Size(180, 20);
      this.txtAusgSumme.TabIndex = 3;
      // 
      // txtAusgProdukte
      // 
      this.txtAusgProdukte.Enabled = false;
      this.txtAusgProdukte.Location = new System.Drawing.Point(104, 84);
      this.txtAusgProdukte.Name = "txtAusgProdukte";
      this.txtAusgProdukte.Size = new System.Drawing.Size(180, 20);
      this.txtAusgProdukte.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(45, 87);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Produkte:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(53, 113);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(45, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Summe:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(47, 139);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(51, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "Prüfziffer:";
      // 
      // btnEingabeKorrekt
      // 
      this.btnEingabeKorrekt.Location = new System.Drawing.Point(41, 177);
      this.btnEingabeKorrekt.Name = "btnEingabeKorrekt";
      this.btnEingabeKorrekt.Size = new System.Drawing.Size(75, 44);
      this.btnEingabeKorrekt.TabIndex = 8;
      this.btnEingabeKorrekt.Text = "Zahlenfolge Korrekt";
      this.btnEingabeKorrekt.UseVisualStyleBackColor = true;
      this.btnEingabeKorrekt.Click += new System.EventHandler(this.btnEingabeKorrekt_Click);
      // 
      // btnPruefziffer
      // 
      this.btnPruefziffer.Location = new System.Drawing.Point(131, 177);
      this.btnPruefziffer.Name = "btnPruefziffer";
      this.btnPruefziffer.Size = new System.Drawing.Size(75, 44);
      this.btnPruefziffer.TabIndex = 9;
      this.btnPruefziffer.Text = "Prüfziffer ermitteln";
      this.btnPruefziffer.UseVisualStyleBackColor = true;
      this.btnPruefziffer.Click += new System.EventHandler(this.btnPruefziffer_Click);
      // 
      // txtISBN
      // 
      this.txtISBN.Location = new System.Drawing.Point(104, 57);
      this.txtISBN.Name = "txtISBN";
      this.txtISBN.Size = new System.Drawing.Size(126, 20);
      this.txtISBN.TabIndex = 10;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(33, 34);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(66, 13);
      this.label5.TabIndex = 11;
      this.label5.Text = "Zahlenfolge:";
      // 
      // btnISBNCheck
      // 
      this.btnISBNCheck.Location = new System.Drawing.Point(221, 177);
      this.btnISBNCheck.Name = "btnISBNCheck";
      this.btnISBNCheck.Size = new System.Drawing.Size(75, 44);
      this.btnISBNCheck.TabIndex = 14;
      this.btnISBNCheck.Text = "ISBN prüfen";
      this.btnISBNCheck.UseVisualStyleBackColor = true;
      this.btnISBNCheck.Click += new System.EventHandler(this.btnISBNCheck_Click);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(21, 246);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(78, 13);
      this.label7.TabIndex = 16;
      this.label7.Text = "ISBN komplett:";
      // 
      // txtISBNVollst
      // 
      this.txtISBNVollst.Location = new System.Drawing.Point(104, 243);
      this.txtISBNVollst.Name = "txtISBNVollst";
      this.txtISBNVollst.Size = new System.Drawing.Size(180, 20);
      this.txtISBNVollst.TabIndex = 15;
      // 
      // txtPZ
      // 
      this.txtPZ.Location = new System.Drawing.Point(260, 57);
      this.txtPZ.Name = "txtPZ";
      this.txtPZ.Size = new System.Drawing.Size(24, 20);
      this.txtPZ.TabIndex = 17;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(230, 60);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(24, 13);
      this.label6.TabIndex = 18;
      this.label6.Text = "PZ:";
      // 
      // ISBNPruef
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(318, 304);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.txtPZ);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.txtISBNVollst);
      this.Controls.Add(this.btnISBNCheck);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.txtISBN);
      this.Controls.Add(this.btnPruefziffer);
      this.Controls.Add(this.btnEingabeKorrekt);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtAusgProdukte);
      this.Controls.Add(this.txtAusgSumme);
      this.Controls.Add(this.txtAusgPruefZiffer);
      this.Controls.Add(this.txtZahlenfolge);
      this.Controls.Add(this.label1);
      this.Name = "ISBNPruef";
      this.Text = "ISBN - Prüfung";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZahlenfolge;
        private System.Windows.Forms.TextBox txtAusgPruefZiffer;
        private System.Windows.Forms.TextBox txtAusgSumme;
        private System.Windows.Forms.TextBox txtAusgProdukte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEingabeKorrekt;
        private System.Windows.Forms.Button btnPruefziffer;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnISBNCheck;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtISBNVollst;
        private System.Windows.Forms.TextBox txtPZ;
        private System.Windows.Forms.Label label6;
    }
}

