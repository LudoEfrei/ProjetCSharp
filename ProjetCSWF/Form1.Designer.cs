namespace ProjetCSWF
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
            this.Entreprises = new System.Windows.Forms.Button();
            this.Employés = new System.Windows.Forms.Button();
            this.Missions = new System.Windows.Forms.Button();
            this.liste_emp = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.liste_emp)).BeginInit();
            this.SuspendLayout();
            // 
            // Entreprises
            // 
            this.Entreprises.Location = new System.Drawing.Point(12, 12);
            this.Entreprises.Name = "Entreprises";
            this.Entreprises.Size = new System.Drawing.Size(93, 53);
            this.Entreprises.TabIndex = 0;
            this.Entreprises.Text = "Entreprises";
            this.Entreprises.UseVisualStyleBackColor = true;
            // 
            // Employés
            // 
            this.Employés.Location = new System.Drawing.Point(122, 12);
            this.Employés.Name = "Employés";
            this.Employés.Size = new System.Drawing.Size(93, 53);
            this.Employés.TabIndex = 1;
            this.Employés.Text = "Employés";
            this.Employés.UseVisualStyleBackColor = true;
            this.Employés.Click += new System.EventHandler(this.Employés_Click);
            // 
            // Missions
            // 
            this.Missions.Location = new System.Drawing.Point(236, 12);
            this.Missions.Name = "Missions";
            this.Missions.Size = new System.Drawing.Size(93, 53);
            this.Missions.TabIndex = 2;
            this.Missions.Text = "Missions";
            this.Missions.UseCompatibleTextRendering = true;
            this.Missions.UseVisualStyleBackColor = true;
            // 
            // liste_emp
            // 
            this.liste_emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste_emp.Location = new System.Drawing.Point(12, 100);
            this.liste_emp.Name = "liste_emp";
            this.liste_emp.Size = new System.Drawing.Size(240, 150);
            this.liste_emp.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(404, 327);
            this.Controls.Add(this.liste_emp);
            this.Controls.Add(this.Missions);
            this.Controls.Add(this.Employés);
            this.Controls.Add(this.Entreprises);
            this.Name = "Form1";
            this.Text = "Kinterimo";
            ((System.ComponentModel.ISupportInitialize)(this.liste_emp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Entreprises;
        private System.Windows.Forms.Button Employés;
        private System.Windows.Forms.Button Missions;
        private System.Windows.Forms.DataGridView liste_emp;

    }
}

