namespace Inventory_Manager
{
    partial class Полная_таблица
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnCategory = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnCatgoryExact = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnNum = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnProducer = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnArticul = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnOffice = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnRoom = new System.Windows.Forms.DataGridViewLinkColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCategory,
            this.ColumnCatgoryExact,
            this.ColumnName,
            this.ColumnDescription,
            this.ColumnNum,
            this.ColumnPrice,
            this.ColumnProducer,
            this.ColumnArticul,
            this.ColumnOffice,
            this.ColumnRoom});
            this.dataGridView1.Location = new System.Drawing.Point(12, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 49;
            this.dataGridView1.Size = new System.Drawing.Size(2544, 351);
            this.dataGridView1.TabIndex = 2;
            // 
            // ColumnCategory
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.ColumnCategory.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnCategory.HeaderText = "Категория";
            this.ColumnCategory.MinimumWidth = 12;
            this.ColumnCategory.Name = "ColumnCategory";
            this.ColumnCategory.ReadOnly = true;
            this.ColumnCategory.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnCategory.Width = 250;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(800, 569);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(777, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "Сохранить изменения";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(190)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2544, 99);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(1232, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "укажите";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(2262, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 58);
            this.button2.TabIndex = 3;
            this.button2.Text = "Открыть";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(1849, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(383, 44);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "АА00001";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.comboBox2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "артикул",
            "название"});
            this.comboBox2.Location = new System.Drawing.Point(1426, 31);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(383, 45);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "артикул";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(74, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1134, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Посмотреть подробную информацию о конкретном предмете:";
            // 
            // Полная_таблица
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(2563, 715);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Полная_таблица";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Полная_таблица";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dataGridView1;
        private Button button1;
        private DataGridViewLinkColumn ColumnCategory;
        private DataGridViewLinkColumn ColumnCatgoryExact;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewLinkColumn ColumnDescription;
        private DataGridViewLinkColumn ColumnNum;
        private DataGridViewLinkColumn ColumnPrice;
        private DataGridViewLinkColumn ColumnProducer;
        private DataGridViewLinkColumn ColumnArticul;
        private DataGridViewLinkColumn ColumnOffice;
        private DataGridViewLinkColumn ColumnRoom;
        private Panel panel2;
        private Label label3;
        private Button button2;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private Label label1;
    }
}