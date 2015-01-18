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
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_editerfiche = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.liste1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Missions";
            // 
            // button_Valider
            // 
            this.button_Valider.Location = new System.Drawing.Point(107, 51);
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
            this.liste1.Size = new System.Drawing.Size(332, 154);
            this.liste1.TabIndex = 8;
            // 
            // button_supprimer
            // 
            this.button_supprimer.Location = new System.Drawing.Point(26, 240);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(75, 23);
            this.button_supprimer.TabIndex = 9;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = true;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // button_editerfiche
            // 
            this.button_editerfiche.Location = new System.Drawing.Point(275, 240);
            this.button_editerfiche.Name = "button_editerfiche";
            this.button_editerfiche.Size = new System.Drawing.Size(83, 35);
            this.button_editerfiche.TabIndex = 10;
            this.button_editerfiche.Text = "Editer la fiche de suivi";
            this.button_editerfiche.UseVisualStyleBackColor = true;
            this.button_editerfiche.Click += new System.EventHandler(this.button_editerfiche_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(367, 298);
            this.Controls.Add(this.button_editerfiche);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.button_Valider);
            this.Controls.Add(this.button_Ajouter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.liste1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.liste1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView liste1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Ajouter;
        private System.Windows.Forms.Button button_Valider;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_editerfiche;
    }
}