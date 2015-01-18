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
            this.button_Ent = new System.Windows.Forms.Button();
            this.button_empl = new System.Windows.Forms.Button();
            this.button_miss = new System.Windows.Forms.Button();
            this.Kinterimo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Ent
            // 
            this.button_Ent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Ent.Location = new System.Drawing.Point(146, 73);
            this.button_Ent.Name = "button_Ent";
            this.button_Ent.Size = new System.Drawing.Size(93, 53);
            this.button_Ent.TabIndex = 0;
            this.button_Ent.Text = "Entreprises";
            this.button_Ent.UseVisualStyleBackColor = true;
            this.button_Ent.Click += new System.EventHandler(this.button_Ent_Click);
            // 
            // button_empl
            // 
            this.button_empl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_empl.Location = new System.Drawing.Point(146, 144);
            this.button_empl.Name = "button_empl";
            this.button_empl.Size = new System.Drawing.Size(93, 53);
            this.button_empl.TabIndex = 1;
            this.button_empl.Text = "Employés";
            this.button_empl.UseVisualStyleBackColor = true;
            this.button_empl.Click += new System.EventHandler(this.button_empl_Click);
            // 
            // button_miss
            // 
            this.button_miss.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_miss.Location = new System.Drawing.Point(146, 213);
            this.button_miss.Name = "button_miss";
            this.button_miss.Size = new System.Drawing.Size(93, 53);
            this.button_miss.TabIndex = 2;
            this.button_miss.Text = "Missions";
            this.button_miss.UseCompatibleTextRendering = true;
            this.button_miss.UseVisualStyleBackColor = true;
            this.button_miss.Click += new System.EventHandler(this.button_miss_Click);
            // 
            // Kinterimo
            // 
            this.Kinterimo.AutoSize = true;
            this.Kinterimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kinterimo.Location = new System.Drawing.Point(131, 9);
            this.Kinterimo.Name = "Kinterimo";
            this.Kinterimo.Size = new System.Drawing.Size(128, 31);
            this.Kinterimo.TabIndex = 4;
            this.Kinterimo.Text = "Kinterimo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(404, 327);
            this.Controls.Add(this.button_Ent);
            this.Controls.Add(this.Kinterimo);
            this.Controls.Add(this.button_miss);
            this.Controls.Add(this.button_empl);
            this.Name = "Form1";
            this.Text = "Kinterimo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Ent;
        private System.Windows.Forms.Button button_empl;
        private System.Windows.Forms.Button button_miss;
        private System.Windows.Forms.Label Kinterimo;

    }
}

