namespace LabMySqlCSharp
{
    partial class Form1
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
            this.loadButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxHostname = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxTablename = new System.Windows.Forms.TextBox();
            this.textBoxDatabaseName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonOrderExecute = new System.Windows.Forms.Button();
            this.textBoxOrderCount = new System.Windows.Forms.TextBox();
            this.textBoxOrderBuyer = new System.Windows.Forms.TextBox();
            this.textBoxOrderDatabase = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonQueryFind = new System.Windows.Forms.Button();
            this.textBoxQuery = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loadButton.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold);
            this.loadButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.loadButton.Location = new System.Drawing.Point(12, 535);
            this.loadButton.Margin = new System.Windows.Forms.Padding(0);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(490, 64);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 169);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(984, 360);
            this.dataGridView1.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold);
            this.saveButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.saveButton.Location = new System.Drawing.Point(506, 535);
            this.saveButton.Margin = new System.Windows.Forms.Padding(0);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(490, 64);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "MySQL Connection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Himalaya", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(16, 16, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hostname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Himalaya", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(16, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(16, 8, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Himalaya", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(16, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Controls.Add(this.textBoxHostname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 149);
            this.panel1.TabIndex = 8;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.BackColor = System.Drawing.Color.Linen;
            this.textBoxPassword.Location = new System.Drawing.Point(91, 111);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(158, 20);
            this.textBoxPassword.TabIndex = 9;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUsername.BackColor = System.Drawing.Color.Linen;
            this.textBoxUsername.Location = new System.Drawing.Point(91, 85);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(158, 20);
            this.textBoxUsername.TabIndex = 8;
            // 
            // textBoxHostname
            // 
            this.textBoxHostname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHostname.BackColor = System.Drawing.Color.Linen;
            this.textBoxHostname.Location = new System.Drawing.Point(91, 59);
            this.textBoxHostname.Name = "textBoxHostname";
            this.textBoxHostname.Size = new System.Drawing.Size(158, 20);
            this.textBoxHostname.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textBoxTablename);
            this.panel2.Controls.Add(this.textBoxDatabaseName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(289, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 149);
            this.panel2.TabIndex = 10;
            // 
            // textBoxTablename
            // 
            this.textBoxTablename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTablename.BackColor = System.Drawing.Color.Linen;
            this.textBoxTablename.Location = new System.Drawing.Point(120, 94);
            this.textBoxTablename.Name = "textBoxTablename";
            this.textBoxTablename.Size = new System.Drawing.Size(97, 20);
            this.textBoxTablename.TabIndex = 9;
            // 
            // textBoxDatabaseName
            // 
            this.textBoxDatabaseName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDatabaseName.BackColor = System.Drawing.Color.Linen;
            this.textBoxDatabaseName.Location = new System.Drawing.Point(120, 68);
            this.textBoxDatabaseName.Name = "textBoxDatabaseName";
            this.textBoxDatabaseName.Size = new System.Drawing.Size(97, 20);
            this.textBoxDatabaseName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Himalaya", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(45, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Table";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label6.Location = new System.Drawing.Point(32, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 39);
            this.label6.TabIndex = 3;
            this.label6.Text = "DB Connection";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Himalaya", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(45, 70);
            this.label7.Margin = new System.Windows.Forms.Padding(16, 8, 0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Database";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.LightCyan;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.buttonOrderExecute);
            this.panel3.Controls.Add(this.textBoxOrderCount);
            this.panel3.Controls.Add(this.textBoxOrderBuyer);
            this.panel3.Controls.Add(this.textBoxOrderDatabase);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.buttonQueryFind);
            this.panel3.Controls.Add(this.textBoxQuery);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(567, 12);
            this.panel3.Margin = new System.Windows.Forms.Padding(8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(429, 149);
            this.panel3.TabIndex = 11;
            // 
            // buttonOrderExecute
            // 
            this.buttonOrderExecute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOrderExecute.Font = new System.Drawing.Font("Microsoft Himalaya", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrderExecute.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonOrderExecute.Location = new System.Drawing.Point(125, 109);
            this.buttonOrderExecute.Name = "buttonOrderExecute";
            this.buttonOrderExecute.Size = new System.Drawing.Size(282, 20);
            this.buttonOrderExecute.TabIndex = 19;
            this.buttonOrderExecute.Text = "Execute";
            this.buttonOrderExecute.UseVisualStyleBackColor = true;
            // 
            // textBoxOrderCount
            // 
            this.textBoxOrderCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOrderCount.BackColor = System.Drawing.Color.Linen;
            this.textBoxOrderCount.Location = new System.Drawing.Point(317, 86);
            this.textBoxOrderCount.Name = "textBoxOrderCount";
            this.textBoxOrderCount.Size = new System.Drawing.Size(90, 20);
            this.textBoxOrderCount.TabIndex = 18;
            // 
            // textBoxOrderBuyer
            // 
            this.textBoxOrderBuyer.BackColor = System.Drawing.Color.Linen;
            this.textBoxOrderBuyer.Location = new System.Drawing.Point(125, 86);
            this.textBoxOrderBuyer.Name = "textBoxOrderBuyer";
            this.textBoxOrderBuyer.Size = new System.Drawing.Size(90, 20);
            this.textBoxOrderBuyer.TabIndex = 17;
            // 
            // textBoxOrderDatabase
            // 
            this.textBoxOrderDatabase.BackColor = System.Drawing.Color.Linen;
            this.textBoxOrderDatabase.Location = new System.Drawing.Point(221, 86);
            this.textBoxOrderDatabase.Name = "textBoxOrderDatabase";
            this.textBoxOrderDatabase.Size = new System.Drawing.Size(90, 20);
            this.textBoxOrderDatabase.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Himalaya", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkBlue;
            this.label12.Location = new System.Drawing.Point(338, 70);
            this.label12.Margin = new System.Windows.Forms.Padding(16, 8, 0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 21);
            this.label12.TabIndex = 14;
            this.label12.Text = "Count";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Himalaya", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkBlue;
            this.label11.Location = new System.Drawing.Point(232, 70);
            this.label11.Margin = new System.Windows.Forms.Padding(16, 8, 0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 21);
            this.label11.TabIndex = 13;
            this.label11.Text = "Database";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Himalaya", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkBlue;
            this.label10.Location = new System.Drawing.Point(148, 70);
            this.label10.Margin = new System.Windows.Forms.Padding(16, 8, 0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 21);
            this.label10.TabIndex = 10;
            this.label10.Text = "Buyer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label8.Location = new System.Drawing.Point(20, 86);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 39);
            this.label8.TabIndex = 12;
            this.label8.Text = "Order";
            // 
            // buttonQueryFind
            // 
            this.buttonQueryFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQueryFind.Font = new System.Drawing.Font("Microsoft Himalaya", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQueryFind.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonQueryFind.Location = new System.Drawing.Point(125, 33);
            this.buttonQueryFind.Name = "buttonQueryFind";
            this.buttonQueryFind.Size = new System.Drawing.Size(282, 20);
            this.buttonQueryFind.TabIndex = 11;
            this.buttonQueryFind.Text = "Find";
            this.buttonQueryFind.UseVisualStyleBackColor = true;
            this.buttonQueryFind.Click += new System.EventHandler(this.buttonQueryFind_Click);
            // 
            // textBoxQuery
            // 
            this.textBoxQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQuery.BackColor = System.Drawing.Color.Linen;
            this.textBoxQuery.Location = new System.Drawing.Point(125, 10);
            this.textBoxQuery.Name = "textBoxQuery";
            this.textBoxQuery.Size = new System.Drawing.Size(282, 20);
            this.textBoxQuery.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label9.Location = new System.Drawing.Point(20, 10);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 39);
            this.label9.TabIndex = 3;
            this.label9.Text = "Query";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1008, 608);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.loadButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxHostname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxTablename;
        private System.Windows.Forms.TextBox textBoxDatabaseName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonQueryFind;
        private System.Windows.Forms.TextBox textBoxQuery;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonOrderExecute;
        private System.Windows.Forms.TextBox textBoxOrderCount;
        private System.Windows.Forms.TextBox textBoxOrderBuyer;
        private System.Windows.Forms.TextBox textBoxOrderDatabase;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
    }
}

