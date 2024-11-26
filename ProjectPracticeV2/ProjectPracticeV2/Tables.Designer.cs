namespace ProjectPracticeV2
{
    partial class Tables
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
            this.ExitForm = new System.Windows.Forms.Button();
            this.RollUpForm = new System.Windows.Forms.Button();
            this.TableStaff = new System.Windows.Forms.DataGridView();
            this.ButtonStaff = new System.Windows.Forms.Button();
            this.ButtonJobs = new System.Windows.Forms.Button();
            this.TableJobs = new System.Windows.Forms.DataGridView();
            this.ButtonAssignments = new System.Windows.Forms.Button();
            this.TableAssignments = new System.Windows.Forms.DataGridView();
            this.ButtonExitAccount = new System.Windows.Forms.Button();
            this.ButtonRequests = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableAssignments)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitForm
            // 
            this.ExitForm.BackColor = System.Drawing.Color.Transparent;
            this.ExitForm.BackgroundImage = global::ProjectPracticeV2.Properties.Resources.Exit;
            this.ExitForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitForm.Location = new System.Drawing.Point(739, 12);
            this.ExitForm.Name = "ExitForm";
            this.ExitForm.Size = new System.Drawing.Size(33, 33);
            this.ExitForm.TabIndex = 1;
            this.ExitForm.UseVisualStyleBackColor = false;
            this.ExitForm.Click += new System.EventHandler(this.ExitForm_Click);
            // 
            // RollUpForm
            // 
            this.RollUpForm.BackColor = System.Drawing.Color.Transparent;
            this.RollUpForm.BackgroundImage = global::ProjectPracticeV2.Properties.Resources.RollUp;
            this.RollUpForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RollUpForm.Location = new System.Drawing.Point(672, 20);
            this.RollUpForm.Name = "RollUpForm";
            this.RollUpForm.Size = new System.Drawing.Size(47, 17);
            this.RollUpForm.TabIndex = 2;
            this.RollUpForm.UseVisualStyleBackColor = false;
            this.RollUpForm.Click += new System.EventHandler(this.RollUpForm_Click);
            // 
            // TableStaff
            // 
            this.TableStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableStaff.Location = new System.Drawing.Point(350, 51);
            this.TableStaff.Name = "TableStaff";
            this.TableStaff.Size = new System.Drawing.Size(422, 148);
            this.TableStaff.TabIndex = 3;
            // 
            // ButtonStaff
            // 
            this.ButtonStaff.BackColor = System.Drawing.Color.Transparent;
            this.ButtonStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStaff.ForeColor = System.Drawing.Color.Yellow;
            this.ButtonStaff.Location = new System.Drawing.Point(105, 51);
            this.ButtonStaff.Name = "ButtonStaff";
            this.ButtonStaff.Size = new System.Drawing.Size(178, 45);
            this.ButtonStaff.TabIndex = 5;
            this.ButtonStaff.Text = "Таблица \"Сотрудники\"";
            this.ButtonStaff.UseVisualStyleBackColor = false;
            this.ButtonStaff.Click += new System.EventHandler(this.ButtonStaff_Click);
            // 
            // ButtonJobs
            // 
            this.ButtonJobs.BackColor = System.Drawing.Color.Transparent;
            this.ButtonJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonJobs.ForeColor = System.Drawing.Color.Yellow;
            this.ButtonJobs.Location = new System.Drawing.Point(105, 132);
            this.ButtonJobs.Name = "ButtonJobs";
            this.ButtonJobs.Size = new System.Drawing.Size(178, 45);
            this.ButtonJobs.TabIndex = 6;
            this.ButtonJobs.Text = "Таблица \"Работы\"";
            this.ButtonJobs.UseVisualStyleBackColor = false;
            this.ButtonJobs.Click += new System.EventHandler(this.ButtonJobs_Click);
            // 
            // TableJobs
            // 
            this.TableJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableJobs.Location = new System.Drawing.Point(350, 51);
            this.TableJobs.Name = "TableJobs";
            this.TableJobs.Size = new System.Drawing.Size(422, 161);
            this.TableJobs.TabIndex = 7;
            // 
            // ButtonAssignments
            // 
            this.ButtonAssignments.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAssignments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAssignments.ForeColor = System.Drawing.Color.Yellow;
            this.ButtonAssignments.Location = new System.Drawing.Point(105, 213);
            this.ButtonAssignments.Name = "ButtonAssignments";
            this.ButtonAssignments.Size = new System.Drawing.Size(178, 45);
            this.ButtonAssignments.TabIndex = 8;
            this.ButtonAssignments.Text = "Таблица \"Поручения\"";
            this.ButtonAssignments.UseVisualStyleBackColor = false;
            this.ButtonAssignments.Click += new System.EventHandler(this.ButtonAssignments_Click);
            // 
            // TableAssignments
            // 
            this.TableAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableAssignments.Location = new System.Drawing.Point(350, 51);
            this.TableAssignments.Name = "TableAssignments";
            this.TableAssignments.Size = new System.Drawing.Size(422, 186);
            this.TableAssignments.TabIndex = 9;
            // 
            // ButtonExitAccount
            // 
            this.ButtonExitAccount.BackColor = System.Drawing.Color.Transparent;
            this.ButtonExitAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExitAccount.ForeColor = System.Drawing.Color.Yellow;
            this.ButtonExitAccount.Location = new System.Drawing.Point(105, 504);
            this.ButtonExitAccount.Name = "ButtonExitAccount";
            this.ButtonExitAccount.Size = new System.Drawing.Size(178, 45);
            this.ButtonExitAccount.TabIndex = 10;
            this.ButtonExitAccount.Text = "Выйти из аккаунта";
            this.ButtonExitAccount.UseVisualStyleBackColor = false;
            this.ButtonExitAccount.Click += new System.EventHandler(this.ButtonExitAccount_Click);
            // 
            // ButtonRequests
            // 
            this.ButtonRequests.BackColor = System.Drawing.Color.Transparent;
            this.ButtonRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRequests.ForeColor = System.Drawing.Color.Yellow;
            this.ButtonRequests.Location = new System.Drawing.Point(105, 434);
            this.ButtonRequests.Name = "ButtonRequests";
            this.ButtonRequests.Size = new System.Drawing.Size(178, 45);
            this.ButtonRequests.TabIndex = 11;
            this.ButtonRequests.Text = "Запросы";
            this.ButtonRequests.UseVisualStyleBackColor = false;
            this.ButtonRequests.Click += new System.EventHandler(this.ButtonRequests_Click);
            // 
            // Tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectPracticeV2.Properties.Resources.Window;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ButtonRequests);
            this.Controls.Add(this.ButtonExitAccount);
            this.Controls.Add(this.TableAssignments);
            this.Controls.Add(this.ButtonAssignments);
            this.Controls.Add(this.TableJobs);
            this.Controls.Add(this.ButtonJobs);
            this.Controls.Add(this.ButtonStaff);
            this.Controls.Add(this.TableStaff);
            this.Controls.Add(this.RollUpForm);
            this.Controls.Add(this.ExitForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tables";
            this.Text = "Tables";
            this.Load += new System.EventHandler(this.Tables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableAssignments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitForm;
        private System.Windows.Forms.Button RollUpForm;
        private System.Windows.Forms.DataGridView TableStaff;
        private System.Windows.Forms.Button ButtonStaff;
        private System.Windows.Forms.Button ButtonJobs;
        private System.Windows.Forms.DataGridView TableJobs;
        private System.Windows.Forms.Button ButtonAssignments;
        private System.Windows.Forms.DataGridView TableAssignments;
        private System.Windows.Forms.Button ButtonExitAccount;
        private System.Windows.Forms.Button ButtonRequests;
    }
}