namespace ProjetCSWF
{
    partial class Form2
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
            this.liste1 = new System.Windows.Forms.DataGridView();
            this.button_valider = new System.Windows.Forms.Button();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_rechercher = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_competences = new System.Windows.Forms.CheckBox();
            this.button_supprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.liste1)).BeginInit();
            this.SuspendLayout();
            // 
            // liste1
            // 
            this.liste1.AllowUserToAddRows = false;
            this.liste1.AllowUserToDeleteRows = false;
            this.liste1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.liste1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste1.Location = new System.Drawing.Point(29, 123);
            this.liste1.Name = "liste1";
            this.liste1.ReadOnly = true;
            this.liste1.Size = new System.Drawing.Size(450, 344);
            this.liste1.TabIndex = 4;
            // 
            // button_valider
            // 
            this.button_valider.Location = new System.Drawing.Point(404, 473);
            this.button_valider.Name = "button_valider";
            this.button_valider.Size = new System.Drawing.Size(75, 23);
            this.button_valider.TabIndex = 5;
            this.button_valider.Text = "Valider";
            this.button_valider.UseVisualStyleBackColor = true;
            this.button_valider.Visible = false;
            this.button_valider.Click += new System.EventHandler(this.button_valider_Click);
            // 
            // button_ajouter
            // 
            this.button_ajouter.Location = new System.Drawing.Point(29, 85);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(75, 23);
            this.button_ajouter.TabIndex = 6;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Employés Intérimaires";
            // 
            // textBox_rechercher
            // 
            this.textBox_rechercher.Location = new System.Drawing.Point(345, 85);
            this.textBox_rechercher.Name = "textBox_rechercher";
            this.textBox_rechercher.Size = new System.Drawing.Size(134, 20);
            this.textBox_rechercher.TabIndex = 8;
            this.textBox_rechercher.TextChanged += new System.EventHandler(this.textBox_rechercher_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rechercher :";
            // 
            // checkBox_competences
            // 
            this.checkBox_competences.AutoSize = true;
            this.checkBox_competences.Location = new System.Drawing.Point(345, 62);
            this.checkBox_competences.Name = "checkBox_competences";
            this.checkBox_competences.Size = new System.Drawing.Size(91, 17);
            this.checkBox_competences.TabIndex = 10;
            this.checkBox_competences.Text = "Compétences";
            this.checkBox_competences.UseVisualStyleBackColor = true;
            this.checkBox_competences.CheckedChanged += new System.EventHandler(this.checkBox_competences_CheckedChanged);
            // 
            // button_supprimer
            // 
            this.button_supprimer.Location = new System.Drawing.Point(110, 85);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(75, 23);
            this.button_supprimer.TabIndex = 11;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = true;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(501, 508);
            this.Controls.Add(this.checkBox_competences);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_rechercher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_ajouter);
            this.Controls.Add(this.button_valider);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.liste1);
            this.Name = "Form2";
            this.Text = "Liste des intérimaires";
            ((System.ComponentModel.ISupportInitialize)(this.liste1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }      


        #endregion

        private System.Windows.Forms.DataGridView liste1;
        private System.Windows.Forms.Button button_valider;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_rechercher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_competences;
        private System.Windows.Forms.Button button_supprimer;

    }
}