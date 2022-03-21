namespace EindogaveDapper
{
    partial class Form1
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
            this.cmbCampussen = new System.Windows.Forms.ComboBox();
            this.lstDocenten = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.txtFamilienaam = new System.Windows.Forms.TextBox();
            this.txtWedde = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.lblDocentNaam = new System.Windows.Forms.Label();
            this.lblFamilieNaam = new System.Windows.Forms.Label();
            this.lblWedde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCampussen
            // 
            this.cmbCampussen.FormattingEnabled = true;
            this.cmbCampussen.Location = new System.Drawing.Point(40, 50);
            this.cmbCampussen.Name = "cmbCampussen";
            this.cmbCampussen.Size = new System.Drawing.Size(413, 24);
            this.cmbCampussen.TabIndex = 0;
            this.cmbCampussen.SelectedIndexChanged += new System.EventHandler(this.cmbCampussen_SelectedIndexChanged);
            // 
            // lstDocenten
            // 
            this.lstDocenten.FormattingEnabled = true;
            this.lstDocenten.ItemHeight = 16;
            this.lstDocenten.Location = new System.Drawing.Point(40, 163);
            this.lstDocenten.Name = "lstDocenten";
            this.lstDocenten.Size = new System.Drawing.Size(413, 164);
            this.lstDocenten.TabIndex = 1;
            this.lstDocenten.SelectedIndexChanged += new System.EventHandler(this.lstDocenten_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Voornaam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Familienaam:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Toevoegen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wedde:";
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(179, 365);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(274, 22);
            this.txtVoornaam.TabIndex = 6;
            // 
            // txtFamilienaam
            // 
            this.txtFamilienaam.Location = new System.Drawing.Point(179, 405);
            this.txtFamilienaam.Name = "txtFamilienaam";
            this.txtFamilienaam.Size = new System.Drawing.Size(274, 22);
            this.txtFamilienaam.TabIndex = 7;
            // 
            // txtWedde
            // 
            this.txtWedde.Location = new System.Drawing.Point(179, 448);
            this.txtWedde.Name = "txtWedde";
            this.txtWedde.Size = new System.Drawing.Size(274, 22);
            this.txtWedde.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Selecteer een campus:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Selecteer een Docent:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Docent toevoegen aan campus:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(566, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Details van docent:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(566, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Wedde:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(566, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Familienaam:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(566, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Voornaam:";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(560, 233);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(176, 35);
            this.btnDel.TabIndex = 16;
            this.btnDel.Text = "Verwijder";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lblDocentNaam
            // 
            this.lblDocentNaam.AutoSize = true;
            this.lblDocentNaam.Location = new System.Drawing.Point(684, 116);
            this.lblDocentNaam.Name = "lblDocentNaam";
            this.lblDocentNaam.Size = new System.Drawing.Size(51, 16);
            this.lblDocentNaam.TabIndex = 17;
            this.lblDocentNaam.Text = "label11";
            this.lblDocentNaam.Visible = false;
            // 
            // lblFamilieNaam
            // 
            this.lblFamilieNaam.AutoSize = true;
            this.lblFamilieNaam.Location = new System.Drawing.Point(684, 150);
            this.lblFamilieNaam.Name = "lblFamilieNaam";
            this.lblFamilieNaam.Size = new System.Drawing.Size(51, 16);
            this.lblFamilieNaam.TabIndex = 18;
            this.lblFamilieNaam.Text = "label11";
            this.lblFamilieNaam.Visible = false;
            // 
            // lblWedde
            // 
            this.lblWedde.AutoSize = true;
            this.lblWedde.Location = new System.Drawing.Point(684, 193);
            this.lblWedde.Name = "lblWedde";
            this.lblWedde.Size = new System.Drawing.Size(52, 16);
            this.lblWedde.TabIndex = 19;
            this.lblWedde.Text = "Wedde";
            this.lblWedde.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 522);
            this.Controls.Add(this.lblWedde);
            this.Controls.Add(this.lblFamilieNaam);
            this.Controls.Add(this.lblDocentNaam);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWedde);
            this.Controls.Add(this.txtFamilienaam);
            this.Controls.Add(this.txtVoornaam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDocenten);
            this.Controls.Add(this.cmbCampussen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCampussen;
        private System.Windows.Forms.ListBox lstDocenten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.TextBox txtFamilienaam;
        private System.Windows.Forms.TextBox txtWedde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label lblDocentNaam;
        private System.Windows.Forms.Label lblFamilieNaam;
        private System.Windows.Forms.Label lblWedde;
    }
}

