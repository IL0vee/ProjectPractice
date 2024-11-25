namespace ProjectPractice
{
    partial class ProjectPractice
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Table = new System.Windows.Forms.DataGridView();
            this.Table1 = new System.Windows.Forms.Button();
            this.Table2 = new System.Windows.Forms.Button();
            this.Table3 = new System.Windows.Forms.Button();
            this.Zapros1 = new System.Windows.Forms.Button();
            this.Zapros4 = new System.Windows.Forms.Button();
            this.Zapros2 = new System.Windows.Forms.Button();
            this.Zapros3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Location = new System.Drawing.Point(342, 12);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(446, 185);
            this.Table.TabIndex = 0;
            // 
            // Table1
            // 
            this.Table1.Location = new System.Drawing.Point(69, 12);
            this.Table1.Name = "Table1";
            this.Table1.Size = new System.Drawing.Size(231, 45);
            this.Table1.TabIndex = 1;
            this.Table1.Text = "Таблица 1";
            this.Table1.UseVisualStyleBackColor = true;
            this.Table1.Click += new System.EventHandler(this.Table1_Click);
            // 
            // Table2
            // 
            this.Table2.Location = new System.Drawing.Point(69, 82);
            this.Table2.Name = "Table2";
            this.Table2.Size = new System.Drawing.Size(231, 45);
            this.Table2.TabIndex = 2;
            this.Table2.Text = "Таблица 2";
            this.Table2.UseVisualStyleBackColor = true;
            this.Table2.Click += new System.EventHandler(this.Table2_Click);
            // 
            // Table3
            // 
            this.Table3.Location = new System.Drawing.Point(69, 152);
            this.Table3.Name = "Table3";
            this.Table3.Size = new System.Drawing.Size(231, 45);
            this.Table3.TabIndex = 3;
            this.Table3.Text = "Таблица 3";
            this.Table3.UseVisualStyleBackColor = true;
            this.Table3.Click += new System.EventHandler(this.Table3_Click);
            // 
            // Zapros1
            // 
            this.Zapros1.Location = new System.Drawing.Point(69, 230);
            this.Zapros1.Name = "Zapros1";
            this.Zapros1.Size = new System.Drawing.Size(168, 45);
            this.Zapros1.TabIndex = 4;
            this.Zapros1.Text = "Запрос 1";
            this.Zapros1.UseVisualStyleBackColor = true;
            this.Zapros1.Click += new System.EventHandler(this.Zapros1_Click);
            // 
            // Zapros4
            // 
            this.Zapros4.Location = new System.Drawing.Point(617, 230);
            this.Zapros4.Name = "Zapros4";
            this.Zapros4.Size = new System.Drawing.Size(171, 45);
            this.Zapros4.TabIndex = 5;
            this.Zapros4.Text = "Запрос 4";
            this.Zapros4.UseVisualStyleBackColor = true;
            this.Zapros4.Click += new System.EventHandler(this.Zapros4_Click);
            // 
            // Zapros2
            // 
            this.Zapros2.Location = new System.Drawing.Point(253, 230);
            this.Zapros2.Name = "Zapros2";
            this.Zapros2.Size = new System.Drawing.Size(161, 45);
            this.Zapros2.TabIndex = 6;
            this.Zapros2.Text = "Запрос 2";
            this.Zapros2.UseVisualStyleBackColor = true;
            this.Zapros2.Click += new System.EventHandler(this.Zapros2_Click);
            // 
            // Zapros3
            // 
            this.Zapros3.Location = new System.Drawing.Point(431, 230);
            this.Zapros3.Name = "Zapros3";
            this.Zapros3.Size = new System.Drawing.Size(171, 45);
            this.Zapros3.TabIndex = 7;
            this.Zapros3.Text = "Запрос 3";
            this.Zapros3.UseVisualStyleBackColor = true;
            this.Zapros3.Click += new System.EventHandler(this.Zapros3_Click);
            // 
            // ProjectPractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 305);
            this.Controls.Add(this.Zapros3);
            this.Controls.Add(this.Zapros2);
            this.Controls.Add(this.Zapros4);
            this.Controls.Add(this.Zapros1);
            this.Controls.Add(this.Table3);
            this.Controls.Add(this.Table2);
            this.Controls.Add(this.Table1);
            this.Controls.Add(this.Table);
            this.Name = "ProjectPractice";
            this.Text = "ProjectPractice";
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Button Table1;
        private System.Windows.Forms.Button Table2;
        private System.Windows.Forms.Button Table3;
        private System.Windows.Forms.Button Zapros1;
        private System.Windows.Forms.Button Zapros4;
        private System.Windows.Forms.Button Zapros2;
        private System.Windows.Forms.Button Zapros3;
    }
}

