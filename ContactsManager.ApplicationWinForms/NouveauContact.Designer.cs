namespace ContactsManager.ApplicationWinForms
{
    partial class NouveauContact
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
            this.boutonEnregistrer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.texteNom = new System.Windows.Forms.TextBox();
            this.textePrenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.texteEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.texteTelephone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pickerDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.boutonAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boutonEnregistrer
            // 
            this.boutonEnregistrer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.boutonEnregistrer.Location = new System.Drawing.Point(141, 250);
            this.boutonEnregistrer.Name = "boutonEnregistrer";
            this.boutonEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.boutonEnregistrer.TabIndex = 0;
            this.boutonEnregistrer.Text = "Enregistrer";
            this.boutonEnregistrer.UseVisualStyleBackColor = true;
            this.boutonEnregistrer.Click += new System.EventHandler(this.boutonEnregistrer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom";
            // 
            // texteNom
            // 
            this.texteNom.Location = new System.Drawing.Point(99, 21);
            this.texteNom.Name = "texteNom";
            this.texteNom.Size = new System.Drawing.Size(153, 20);
            this.texteNom.TabIndex = 2;
            // 
            // textePrenom
            // 
            this.textePrenom.Location = new System.Drawing.Point(99, 58);
            this.textePrenom.Name = "textePrenom";
            this.textePrenom.Size = new System.Drawing.Size(153, 20);
            this.textePrenom.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prénom";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // texteEmail
            // 
            this.texteEmail.Location = new System.Drawing.Point(99, 99);
            this.texteEmail.Name = "texteEmail";
            this.texteEmail.Size = new System.Drawing.Size(153, 20);
            this.texteEmail.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // texteTelephone
            // 
            this.texteTelephone.Location = new System.Drawing.Point(99, 141);
            this.texteTelephone.Name = "texteTelephone";
            this.texteTelephone.Size = new System.Drawing.Size(153, 20);
            this.texteTelephone.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Téléphone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date naissance";
            // 
            // pickerDateNaissance
            // 
            this.pickerDateNaissance.Location = new System.Drawing.Point(100, 189);
            this.pickerDateNaissance.Name = "pickerDateNaissance";
            this.pickerDateNaissance.Size = new System.Drawing.Size(152, 20);
            this.pickerDateNaissance.TabIndex = 10;
            // 
            // boutonAnnuler
            // 
            this.boutonAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.boutonAnnuler.Location = new System.Drawing.Point(222, 250);
            this.boutonAnnuler.Name = "boutonAnnuler";
            this.boutonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.boutonAnnuler.TabIndex = 0;
            this.boutonAnnuler.Text = "Annuler";
            this.boutonAnnuler.UseVisualStyleBackColor = true;
            this.boutonAnnuler.Click += new System.EventHandler(this.boutonAnnuler_Click);
            // 
            // NouveauContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 285);
            this.Controls.Add(this.pickerDateNaissance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.texteTelephone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.texteEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textePrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.texteNom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boutonAnnuler);
            this.Controls.Add(this.boutonEnregistrer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NouveauContact";
            this.Text = "Nouveau contact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boutonEnregistrer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texteNom;
        private System.Windows.Forms.TextBox textePrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox texteEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox texteTelephone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker pickerDateNaissance;
        private System.Windows.Forms.Button boutonAnnuler;
    }
}