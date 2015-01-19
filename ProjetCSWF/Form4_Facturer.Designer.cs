namespace ProjetCSWF
{
    partial class Form4_Facturer
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
            this.dataGridView_mission = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_jours = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_salaire = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_valider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mission)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(170, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editer une facture";
            // 
            // dataGridView_mission
            // 
            this.dataGridView_mission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_mission.Location = new System.Drawing.Point(34, 108);
            this.dataGridView_mission.Name = "dataGridView_mission";
            this.dataGridView_mission.Size = new System.Drawing.Size(433, 70);
            this.dataGridView_mission.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(31, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mission : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(31, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre de jours totaux : ";
            // 
            // label_jours
            // 
            this.label_jours.AutoSize = true;
            this.label_jours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_jours.Location = new System.Drawing.Point(212, 190);
            this.label_jours.Name = "label_jours";
            this.label_jours.Size = new System.Drawing.Size(53, 18);
            this.label_jours.TabIndex = 4;
            this.label_jours.Text = "0 jours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(31, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Salaire : ";
            // 
            // textBox_salaire
            // 
            this.textBox_salaire.Location = new System.Drawing.Point(106, 228);
            this.textBox_salaire.Name = "textBox_salaire";
            this.textBox_salaire.Size = new System.Drawing.Size(100, 20);
            this.textBox_salaire.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(222, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "€";
            // 
            // button_valider
            // 
            this.button_valider.Location = new System.Drawing.Point(34, 268);
            this.button_valider.Name = "button_valider";
            this.button_valider.Size = new System.Drawing.Size(75, 23);
            this.button_valider.TabIndex = 8;
            this.button_valider.Text = "Valider";
            this.button_valider.UseVisualStyleBackColor = true;
            this.button_valider.Click += new System.EventHandler(this.button_valider_Click);
            // 
            // Form4_Facturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(522, 315);
            this.Controls.Add(this.button_valider);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_salaire);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_jours);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_mission);
            this.Controls.Add(this.label1);
            this.Name = "Form4_Facturer";
            this.Text = "Editer une facture";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mission)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_mission;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_jours;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_salaire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_valider;
    }
}