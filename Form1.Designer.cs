
namespace CalculationOfSeniority
{
    partial class Seniority
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_1 = new System.Windows.Forms.GroupBox();
            this.dtp_1 = new System.Windows.Forms.DateTimePicker();
            this.gb_2 = new System.Windows.Forms.GroupBox();
            this.dtp_2 = new System.Windows.Forms.DateTimePicker();
            this.Add_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Print_button = new System.Windows.Forms.Button();
            this.About_button = new System.Windows.Forms.Button();
            this.Close_button = new System.Windows.Forms.Button();
            this.gb_3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gb_1.SuspendLayout();
            this.gb_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_1
            // 
            this.gb_1.Controls.Add(this.dtp_1);
            this.gb_1.Location = new System.Drawing.Point(18, 13);
            this.gb_1.Name = "gb_1";
            this.gb_1.Size = new System.Drawing.Size(144, 62);
            this.gb_1.TabIndex = 1;
            this.gb_1.TabStop = false;
            this.gb_1.Text = "Начало периода:";
            // 
            // dtp_1
            // 
            this.dtp_1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_1.Location = new System.Drawing.Point(6, 26);
            this.dtp_1.Name = "dtp_1";
            this.dtp_1.Size = new System.Drawing.Size(120, 27);
            this.dtp_1.TabIndex = 0;
            // 
            // gb_2
            // 
            this.gb_2.Controls.Add(this.dtp_2);
            this.gb_2.Location = new System.Drawing.Point(474, 13);
            this.gb_2.Name = "gb_2";
            this.gb_2.Size = new System.Drawing.Size(144, 62);
            this.gb_2.TabIndex = 2;
            this.gb_2.TabStop = false;
            this.gb_2.Text = "Конец периода:";
            // 
            // dtp_2
            // 
            this.dtp_2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_2.Location = new System.Drawing.Point(6, 26);
            this.dtp_2.Name = "dtp_2";
            this.dtp_2.Size = new System.Drawing.Size(120, 27);
            this.dtp_2.TabIndex = 0;
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(634, 26);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(148, 40);
            this.Add_button.TabIndex = 3;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = true;
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(634, 81);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(148, 40);
            this.Delete_button.TabIndex = 4;
            this.Delete_button.Text = "Удалить";
            this.Delete_button.UseVisualStyleBackColor = true;
            // 
            // Print_button
            // 
            this.Print_button.Location = new System.Drawing.Point(634, 127);
            this.Print_button.Name = "Print_button";
            this.Print_button.Size = new System.Drawing.Size(148, 40);
            this.Print_button.TabIndex = 5;
            this.Print_button.Text = "Печать";
            this.Print_button.UseVisualStyleBackColor = true;
            // 
            // About_button
            // 
            this.About_button.Location = new System.Drawing.Point(634, 361);
            this.About_button.Name = "About_button";
            this.About_button.Size = new System.Drawing.Size(148, 40);
            this.About_button.TabIndex = 6;
            this.About_button.Text = "О программе";
            this.About_button.UseVisualStyleBackColor = true;
            // 
            // Close_button
            // 
            this.Close_button.Location = new System.Drawing.Point(634, 463);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(148, 40);
            this.Close_button.TabIndex = 7;
            this.Close_button.Text = "Закрыть";
            this.Close_button.UseVisualStyleBackColor = true;
            // 
            // gb_3
            // 
            this.gb_3.Location = new System.Drawing.Point(18, 407);
            this.gb_3.Name = "gb_3";
            this.gb_3.Size = new System.Drawing.Size(600, 96);
            this.gb_3.TabIndex = 8;
            this.gb_3.TabStop = false;
            this.gb_3.Text = "Итого:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(18, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(600, 319);
            this.dataGridView1.TabIndex = 9;
            // 
            // Seniority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 518);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gb_3);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.About_button);
            this.Controls.Add(this.Print_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.gb_2);
            this.Controls.Add(this.gb_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Seniority";
            this.Text = "Расчет стажа";
            this.gb_1.ResumeLayout(false);
            this.gb_2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_1;
        private System.Windows.Forms.GroupBox gb_2;
        private System.Windows.Forms.DateTimePicker dtp_2;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Print_button;
        private System.Windows.Forms.Button About_button;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.GroupBox gb_3;
        private System.Windows.Forms.DateTimePicker dtp_1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

