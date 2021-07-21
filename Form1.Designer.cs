
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_1 = new System.Windows.Forms.GroupBox();
            this.DateBegin = new System.Windows.Forms.DateTimePicker();
            this.gb_2 = new System.Windows.Forms.GroupBox();
            this.DateEnd = new System.Windows.Forms.DateTimePicker();
            this.Add_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Print_button = new System.Windows.Forms.Button();
            this.About_button = new System.Windows.Forms.Button();
            this.Close_button = new System.Windows.Forms.Button();
            this.gb_3 = new System.Windows.Forms.GroupBox();
            this.DateBase = new System.Windows.Forms.DataGridView();
            this.Refresh_button = new System.Windows.Forms.Button();
            this.DeleteAll_Button = new System.Windows.Forms.Button();
            this.gb_1.SuspendLayout();
            this.gb_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DateBase)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_1
            // 
            this.gb_1.Controls.Add(this.DateBegin);
            this.gb_1.Location = new System.Drawing.Point(18, 13);
            this.gb_1.Name = "gb_1";
            this.gb_1.Size = new System.Drawing.Size(144, 62);
            this.gb_1.TabIndex = 1;
            this.gb_1.TabStop = false;
            this.gb_1.Text = "Начало периода:";
            // 
            // DateBegin
            // 
            this.DateBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateBegin.Location = new System.Drawing.Point(6, 26);
            this.DateBegin.Name = "DateBegin";
            this.DateBegin.Size = new System.Drawing.Size(120, 27);
            this.DateBegin.TabIndex = 0;
            // 
            // gb_2
            // 
            this.gb_2.Controls.Add(this.DateEnd);
            this.gb_2.Location = new System.Drawing.Point(474, 13);
            this.gb_2.Name = "gb_2";
            this.gb_2.Size = new System.Drawing.Size(144, 62);
            this.gb_2.TabIndex = 2;
            this.gb_2.TabStop = false;
            this.gb_2.Text = "Конец периода:";
            // 
            // DateEnd
            // 
            this.DateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateEnd.Location = new System.Drawing.Point(6, 26);
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Size = new System.Drawing.Size(120, 27);
            this.DateEnd.TabIndex = 0;
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(634, 82);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(148, 40);
            this.Add_button.TabIndex = 3;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(634, 128);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(148, 40);
            this.Delete_button.TabIndex = 4;
            this.Delete_button.Text = "Удалить";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Print_button
            // 
            this.Print_button.Location = new System.Drawing.Point(634, 315);
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
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
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
            // DateBase
            // 
            this.DateBase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DateBase.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DateBase.ColumnHeadersHeight = 29;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DateBase.DefaultCellStyle = dataGridViewCellStyle1;
            this.DateBase.Location = new System.Drawing.Point(18, 82);
            this.DateBase.Name = "DateBase";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DateBase.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DateBase.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.DateBase.RowTemplate.Height = 29;
            this.DateBase.Size = new System.Drawing.Size(600, 319);
            this.DateBase.TabIndex = 9;
            // 
            // Refresh_button
            // 
            this.Refresh_button.Location = new System.Drawing.Point(634, 26);
            this.Refresh_button.Name = "Refresh_button";
            this.Refresh_button.Size = new System.Drawing.Size(148, 40);
            this.Refresh_button.TabIndex = 10;
            this.Refresh_button.Text = "Обновить";
            this.Refresh_button.UseVisualStyleBackColor = true;
            this.Refresh_button.Click += new System.EventHandler(this.Refresh_button_Click);
            // 
            // DeleteAll_Button
            // 
            this.DeleteAll_Button.Location = new System.Drawing.Point(634, 174);
            this.DeleteAll_Button.Name = "DeleteAll_Button";
            this.DeleteAll_Button.Size = new System.Drawing.Size(148, 40);
            this.DeleteAll_Button.TabIndex = 11;
            this.DeleteAll_Button.Text = "Удалить всё";
            this.DeleteAll_Button.UseVisualStyleBackColor = true;
            this.DeleteAll_Button.Click += new System.EventHandler(this.DeleteAll_Button_Click);
            // 
            // Seniority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 518);
            this.Controls.Add(this.DeleteAll_Button);
            this.Controls.Add(this.Refresh_button);
            this.Controls.Add(this.DateBase);
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
            this.Load += new System.EventHandler(this.Seniority_Load);
            this.gb_1.ResumeLayout(false);
            this.gb_2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DateBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_1;
        private System.Windows.Forms.GroupBox gb_2;
        private System.Windows.Forms.DateTimePicker DateEnd;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Print_button;
        private System.Windows.Forms.Button About_button;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.GroupBox gb_3;
        private System.Windows.Forms.DateTimePicker DateBegin;
        private System.Windows.Forms.DataGridView DateBase;
        private System.Windows.Forms.Button Refresh_button;
        private System.Windows.Forms.Button DeleteAll_Button;
    }
}

