namespace ProjetCSWF
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_rechercher = new System.Windows.Forms.TextBox();
            this.checkBox_interimaire = new System.Windows.Forms.CheckBox();
            this.checkBox_risque = new System.Windows.Forms.CheckBox();
            this.button_avancement = new System.Windows.Forms.Button();
            this.button_facturer = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_editerfiche = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.liste1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Missions";
            // 
            // button_Valider
            // 
            this.button_Valider.Location = new System.Drawing.Point(609, 486);
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
            this.button_Ajouter.Location = new System.Drawing.Point(26, 75);
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
            this.liste1.Location = new System.Drawing.Point(26, 113);
            this.liste1.Name = "liste1";
            this.liste1.ReadOnly = true;
            this.liste1.Size = new System.Drawing.Size(658, 366);
            this.liste1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rechercher : ";
            // 
            // textBox_rechercher
            // 
            this.textBox_rechercher.Location = new System.Drawing.Point(546, 77);
            this.textBox_rechercher.Name = "textBox_rechercher";
            this.textBox_rechercher.Size = new System.Drawing.Size(138, 20);
            this.textBox_rechercher.TabIndex = 10;
            this.textBox_rechercher.TextChanged += new System.EventHandler(this.textBox_rechercher_TextChanged);
            // 
            // checkBox_interimaire
            // 
            this.checkBox_interimaire.AutoSize = true;
            this.checkBox_interimaire.Location = new System.Drawing.Point(546, 54);
            this.checkBox_interimaire.Name = "checkBox_interimaire";
            this.checkBox_interimaire.Size = new System.Drawing.Size(74, 17);
            this.checkBox_interimaire.TabIndex = 11;
            this.checkBox_interimaire.Text = "Intérimaire";
            this.checkBox_interimaire.UseVisualStyleBackColor = true;
            this.checkBox_interimaire.CheckedChanged += new System.EventHandler(this.checkBox_interimaire_CheckedChanged);
            // 
            // checkBox_risque
            // 
            this.checkBox_risque.AutoSize = true;
            this.checkBox_risque.Location = new System.Drawing.Point(26, 486);
            this.checkBox_risque.Name = "checkBox_risque";
            this.checkBox_risque.Size = new System.Drawing.Size(91, 17);
            this.checkBox_risque.TabIndex = 12;
            this.checkBox_risque.Text = "Risque > 25%";
            this.checkBox_risque.UseVisualStyleBackColor = true;
            this.checkBox_risque.CheckedChanged += new System.EventHandler(this.checkBox_risque_CheckedChanged);
            // 
            // button_avancement
            // 
            this.button_avancement.Location = new System.Drawing.Point(307, 75);
            this.button_avancement.Name = "button_avancement";
            this.button_avancement.Size = new System.Drawing.Size(146, 23);
            this.button_avancement.TabIndex = 13;
            this.button_avancement.Text = "Avancement entre 2 dates";
            this.button_avancement.UseVisualStyleBackColor = true;
            this.button_avancement.Click += new System.EventHandler(this.button_avancements_Click);
            // 
            // button_facturer
            // 
            this.button_facturer.Location = new System.Drawing.Point(234, 486);
            this.button_facturer.Name = "button_facturer";
            this.button_facturer.Size = new System.Drawing.Size(118, 23);
            this.button_facturer.TabIndex = 14;
            this.button_facturer.Text = "Editer une facture";
            this.button_facturer.UseVisualStyleBackColor = true;
            this.button_facturer.Click += new System.EventHandler(this.button_facturer_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.Location = new System.Drawing.Point(107, 75);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(75, 23);
            this.button_supprimer.TabIndex = 15;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = true;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // button_editerfiche
            // 
            this.button_editerfiche.Location = new System.Drawing.Point(358, 486);
            this.button_editerfiche.Name = "button_editerfiche";
            this.button_editerfiche.Size = new System.Drawing.Size(125, 23);
            this.button_editerfiche.TabIndex = 16;
            this.button_editerfiche.Text = "Editer la fiche de suivi";
            this.button_editerfiche.UseVisualStyleBackColor = true;
            this.button_editerfiche.Click += new System.EventHandler(this.button_editerfiche_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(713, 521);
            this.Controls.Add(this.button_editerfiche);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.button_facturer);
            this.Controls.Add(this.button_avancement);
            this.Controls.Add(this.checkBox_risque);
            this.Controls.Add(this.checkBox_interimaire);
            this.Controls.Add(this.textBox_rechercher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Valider);
            this.Controls.Add(this.button_Ajouter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.liste1);
            this.Name = "Form4";
            this.Text = "Liste des missions";
            ((System.ComponentModel.ISupportInitialize)(this.liste1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView liste1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Ajouter;
        private System.Windows.Forms.Button button_Valider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_rechercher;
        private System.Windows.Forms.CheckBox checkBox_interimaire;
        private System.Windows.Forms.CheckBox checkBox_risque;
        private System.Windows.Forms.Button button_avancement;
        private System.Windows.Forms.Button button_facturer;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_editerfiche;
    }
}