
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_1 = new System.Windows.Forms.GroupBox();
            this.dtp_1 = new System.Windows.Forms.DateTimePicker();
            this.gb_2 = new System.Windows.Forms.GroupBox();
            this.dtp_2 = new System.Windows.Forms.DateTimePicker();
            this.but_1 = new System.Windows.Forms.Button();
            this.but_2 = new System.Windows.Forms.Button();
            this.but_3 = new System.Windows.Forms.Button();
            this.but_4 = new System.Windows.Forms.Button();
            this.but_5 = new System.Windows.Forms.Button();
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
            // but_1
            // 
            this.but_1.Location = new System.Drawing.Point(634, 26);
            this.but_1.Name = "but_1";
            this.but_1.Size = new System.Drawing.Size(148, 40);
            this.but_1.TabIndex = 3;
            this.but_1.Text = "Добавить";
            this.but_1.UseVisualStyleBackColor = true;
            this.but_1.Click += new System.EventHandler(this.but_1_Click);
            // 
            // but_2
            // 
            this.but_2.Location = new System.Drawing.Point(634, 81);
            this.but_2.Name = "but_2";
            this.but_2.Size = new System.Drawing.Size(148, 40);
            this.but_2.TabIndex = 4;
            this.but_2.Text = "Удалить";
            this.but_2.UseVisualStyleBackColor = true;
            this.but_2.Click += new System.EventHandler(this.but_2_Click);
            // 
            // but_3
            // 
            this.but_3.Location = new System.Drawing.Point(634, 127);
            this.but_3.Name = "but_3";
            this.but_3.Size = new System.Drawing.Size(148, 40);
            this.but_3.TabIndex = 5;
            this.but_3.Text = "Печать";
            this.but_3.UseVisualStyleBackColor = true;
            // 
            // but_4
            // 
            this.but_4.Location = new System.Drawing.Point(634, 361);
            this.but_4.Name = "but_4";
            this.but_4.Size = new System.Drawing.Size(148, 40);
            this.but_4.TabIndex = 6;
            this.but_4.Text = "О программе";
            this.but_4.UseVisualStyleBackColor = true;
            // 
            // but_5
            // 
            this.but_5.Location = new System.Drawing.Point(634, 463);
            this.but_5.Name = "but_5";
            this.but_5.Size = new System.Drawing.Size(148, 40);
            this.but_5.TabIndex = 7;
            this.but_5.Text = "Закрыть";
            this.but_5.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
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
            this.Controls.Add(this.but_5);
            this.Controls.Add(this.but_4);
            this.Controls.Add(this.but_3);
            this.Controls.Add(this.but_2);
            this.Controls.Add(this.but_1);
            this.Controls.Add(this.gb_2);
            this.Controls.Add(this.gb_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Seniority";
            this.Text = "Расчет стажа";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_1.ResumeLayout(false);
            this.gb_2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_1;
        private System.Windows.Forms.GroupBox gb_2;
        private System.Windows.Forms.DateTimePicker dtp_2;
        private System.Windows.Forms.Button but_1;
        private System.Windows.Forms.Button but_2;
        private System.Windows.Forms.Button but_3;
        private System.Windows.Forms.Button but_4;
        private System.Windows.Forms.Button but_5;
        private System.Windows.Forms.GroupBox gb_3;
        private System.Windows.Forms.DateTimePicker dtp_1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

