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
            ((System.ComponentModel.ISupportInitialize)(this.liste1)).BeginInit();
            this.SuspendLayout();
            // 
            // liste1
            // 
            this.liste1.AllowUserToAddRows = false;
            this.liste1.AllowUserToDeleteRows = false;
            this.liste1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.liste1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste1.Location = new System.Drawing.Point(26, 89);
            this.liste1.Name = "liste1";
            this.liste1.ReadOnly = true;
            this.liste1.Size = new System.Drawing.Size(332, 154);
            this.liste1.TabIndex = 4;
            // 
            // button_valider
            // 
            this.button_valider.Location = new System.Drawing.Point(107, 51);
            this.button_valider.Name = "button_valider";
            this.button_valider.Size = new System.Drawing.Size(75, 23);
            this.button_valider.TabIndex = 5;
            this.button_valider.Text = "Valider";
            this.button_valider.UseVisualStyleBackColor = true;
            this.button_valider.Click += new System.EventHandler(this.button_valider_Click);
            // 
            // button_ajouter
            // 
            this.button_ajouter.Location = new System.Drawing.Point(26, 51);
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
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Employés Intérimaires";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(383, 287);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_ajouter);
            this.Controls.Add(this.button_valider);
            this.Controls.Add(this.liste1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.liste1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView liste1;
        private System.Windows.Forms.Button button_valider;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.Label label1;

    }
}