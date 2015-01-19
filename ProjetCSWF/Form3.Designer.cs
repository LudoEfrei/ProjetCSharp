namespace ProjetCSWF
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_Valider = new System.Windows.Forms.Button();
            this.button_Ajouter = new System.Windows.Forms.Button();
            this.liste1 = new System.Windows.Forms.DataGridView();
            this.button_adresse = new System.Windows.Forms.Button();
            this.button_contact = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_rechercher = new System.Windows.Forms.TextBox();
            this.button_supprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.liste1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Entreprises";
            // 
            // button_Valider
            // 
            this.button_Valider.Location = new System.Drawing.Point(401, 481);
            this.button_Valider.Name = "button_Valider";
            this.button_Valider.Size = new System.Drawing.Size(75, 23);
            this.button_Valider.TabIndex = 5;
            this.button_Valider.Text = "Valider";
            this.button_Valider.UseVisualStyleBackColor = true;
            this.button_Valider.Visible = false;
            this.button_Valider.Click += new System.EventHandler(this.button_Valider_Click_1);
            // 
            // button_Ajouter
            // 
            this.button_Ajouter.Location = new System.Drawing.Point(26, 51);
            this.button_Ajouter.Name = "button_Ajouter";
            this.button_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.button_Ajouter.TabIndex = 6;
            this.button_Ajouter.Text = "Ajouter";
            this.button_Ajouter.UseVisualStyleBackColor = true;
            this.button_Ajouter.Click += new System.EventHandler(this.button_Ajouter_Click_1);
            // 
            // liste1
            // 
            this.liste1.AllowUserToAddRows = false;
            this.liste1.AllowUserToDeleteRows = false;
            this.liste1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste1.Location = new System.Drawing.Point(26, 80);
            this.liste1.Name = "liste1";
            this.liste1.ReadOnly = true;
            this.liste1.Size = new System.Drawing.Size(450, 395);
            this.liste1.TabIndex = 8;
            this.liste1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.liste1_CellContentClick);
            // 
            // button_adresse
            // 
            this.button_adresse.Location = new System.Drawing.Point(107, 51);
            this.button_adresse.Name = "button_adresse";
            this.button_adresse.Size = new System.Drawing.Size(61, 23);
            this.button_adresse.TabIndex = 9;
            this.button_adresse.Text = "Adresse";
            this.button_adresse.UseVisualStyleBackColor = true;
            this.button_adresse.Visible = false;
            this.button_adresse.Click += new System.EventHandler(this.button_adresse_Click);
            // 
            // button_contact
            // 
            this.button_contact.Location = new System.Drawing.Point(174, 51);
            this.button_contact.Name = "button_contact";
            this.button_contact.Size = new System.Drawing.Size(65, 23);
            this.button_contact.TabIndex = 10;
            this.button_contact.Text = "Contact";
            this.button_contact.UseVisualStyleBackColor = true;
            this.button_contact.Visible = false;
            this.button_contact.Click += new System.EventHandler(this.button_contact_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Rechercher :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_rechercher
            // 
            this.textBox_rechercher.Location = new System.Drawing.Point(339, 53);
            this.textBox_rechercher.Name = "textBox_rechercher";
            this.textBox_rechercher.Size = new System.Drawing.Size(137, 20);
            this.textBox_rechercher.TabIndex = 12;
            this.textBox_rechercher.TextChanged += new System.EventHandler(this.textBox_rechercher_TextChanged);
            // 
            // button_supprimer
            // 
            this.button_supprimer.Location = new System.Drawing.Point(26, 481);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(75, 23);
            this.button_supprimer.TabIndex = 13;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = true;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(502, 513);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.textBox_rechercher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_contact);
            this.Controls.Add(this.button_adresse);
            this.Controls.Add(this.liste1);
            this.Controls.Add(this.button_Ajouter);
            this.Controls.Add(this.button_Valider);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Liste des entreprises";
            ((System.ComponentModel.ISupportInitialize)(this.liste1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Valider;
        private System.Windows.Forms.Button button_Ajouter;
        private System.Windows.Forms.DataGridView liste1;
        private System.Windows.Forms.Button button_adresse;
        private System.Windows.Forms.Button button_contact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_rechercher;
        private System.Windows.Forms.Button button_supprimer;
    }
}