﻿namespace Inventory_Manager
{
    partial class Svedeniya_o_predmete
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnCatgoryExact = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnNum = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnProducer = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnArticul = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnOffice = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnRoom = new System.Windows.Forms.DataGridViewLinkColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Подробная информация о предмете\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(965, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(450, 98);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сохранить изменения";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewLinkColumn1,
            this.ColumnCatgoryExact,
            this.ColumnName,
            this.ColumnDescription,
            this.ColumnNum,
            this.ColumnPrice,
            this.ColumnProducer,
            this.ColumnArticul,
            this.ColumnOffice,
            this.ColumnRoom});
            this.dataGridView1.Location = new System.Drawing.Point(3, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 49;
            this.dataGridView1.Size = new System.Drawing.Size(2537, 152);
            this.dataGridView1.TabIndex = 5;
            // 
            // dataGridViewLinkColumn1
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dataGridViewLinkColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewLinkColumn1.HeaderText = "Категория";
            this.dataGridViewLinkColumn1.MinimumWidth = 12;
            this.dataGridViewLinkColumn1.Name = "dataGridViewLinkColumn1";
            this.dataGridViewLinkColumn1.ReadOnly = true;
            this.dataGridViewLinkColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLinkColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewLinkColumn1.Width = 250;
            // 
            // ColumnCatgoryExact
            // 
            this.ColumnCatgoryExact.HeaderText = "Подкатегория";
            this.ColumnCatgoryExact.MinimumWidth = 12;
            this.ColumnCatgoryExact.Name = "ColumnCatgoryExact";
            this.ColumnCatgoryExact.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnCatgoryExact.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnCatgoryExact.Width = 250;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Название предмета";
            this.ColumnName.MinimumWidth = 12;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 250;
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.HeaderText = "Краткое описание";
            this.ColumnDescription.MinimumWidth = 12;
            this.ColumnDescription.Name = "ColumnDescription";
            this.ColumnDescription.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnDescription.Width = 250;
            // 
            // ColumnNum
            // 
            this.ColumnNum.HeaderText = "Количество ";
            this.ColumnNum.MinimumWidth = 12;
            this.ColumnNum.Name = "ColumnNum";
            this.ColumnNum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnNum.Width = 250;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.HeaderText = "Цена(руб., коп.)";
            this.ColumnPrice.MinimumWidth = 12;
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnPrice.Width = 250;
            // 
            // ColumnProducer
            // 
            this.ColumnProducer.HeaderText = "Производитель";
            this.ColumnProducer.MinimumWidth = 12;
            this.ColumnProducer.Name = "ColumnProducer";
            this.ColumnProducer.Width = 250;
            // 
            // ColumnArticul
            // 
            this.ColumnArticul.HeaderText = "Артикул";
            this.ColumnArticul.MinimumWidth = 12;
            this.ColumnArticul.Name = "ColumnArticul";
            this.ColumnArticul.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnArticul.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnArticul.Width = 250;
            // 
            // ColumnOffice
            // 
            this.ColumnOffice.HeaderText = "Офис";
            this.ColumnOffice.MinimumWidth = 12;
            this.ColumnOffice.Name = "ColumnOffice";
            this.ColumnOffice.Width = 250;
            // 
            // ColumnRoom
            // 
            this.ColumnRoom.HeaderText = "Помещение";
            this.ColumnRoom.MinimumWidth = 12;
            this.ColumnRoom.Name = "ColumnRoom";
            this.ColumnRoom.Width = 250;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 58);
            this.button2.TabIndex = 6;
            this.button2.Text = "<<< назад";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Svedeniya_o_predmete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2552, 482);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Svedeniya_o_predmete";
            this.Text = "Сведения_о_предмете";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewLinkColumn dataGridViewLinkColumn1;
        private DataGridViewLinkColumn ColumnCatgoryExact;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewLinkColumn ColumnDescription;
        private DataGridViewLinkColumn ColumnNum;
        private DataGridViewLinkColumn ColumnPrice;
        private DataGridViewLinkColumn ColumnProducer;
        private DataGridViewLinkColumn ColumnArticul;
        private DataGridViewLinkColumn ColumnOffice;
        private DataGridViewLinkColumn ColumnRoom;
        private Button button2;
    }
}