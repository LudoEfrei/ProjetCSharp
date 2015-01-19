namespace ProjetCSWF
{
    partial class Form4_Avancements
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
            this.dateTimePicker_de = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_a = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_avancements = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_avancements)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_de
            // 
            this.dateTimePicker_de.Location = new System.Drawing.Point(82, 84);
            this.dateTimePicker_de.Name = "dateTimePicker_de";
            this.dateTimePicker_de.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_de.TabIndex = 0;
            this.dateTimePicker_de.ValueChanged += new System.EventHandler(this.dateTimePicker_de_ValueChanged);
            // 
            // dateTimePicker_a
            // 
            this.dateTimePicker_a.Location = new System.Drawing.Point(82, 119);
            this.dateTimePicker_a.Name = "dateTimePicker_a";
            this.dateTimePicker_a.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_a.TabIndex = 1;
            this.dateTimePicker_a.ValueChanged += new System.EventHandler(this.dateTimePicker_a_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "De : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "à : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(67, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Avancements entre 2 dates";
            // 
            // dataGridView_avancements
            // 
            this.dataGridView_avancements.AllowUserToAddRows = false;
            this.dataGridView_avancements.AllowUserToDeleteRows = false;
            this.dataGridView_avancements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_avancements.Location = new System.Drawing.Point(22, 163);
            this.dataGridView_avancements.Name = "dataGridView_avancements";
            this.dataGridView_avancements.ReadOnly = true;
            this.dataGridView_avancements.Size = new System.Drawing.Size(304, 298);
            this.dataGridView_avancements.TabIndex = 5;
            // 
            // Form4_Avancements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(349, 489);
            this.Controls.Add(this.dataGridView_avancements);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_a);
            this.Controls.Add(this.dateTimePicker_de);
            this.Name = "Form4_Avancements";
            this.Text = "Avancements entre 2 dates";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_avancements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_de;
        private System.Windows.Forms.DateTimePicker dateTimePicker_a;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_avancements;
    }
}