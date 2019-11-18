namespace SavingApp
{
    partial class main_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_frm));
            this.lbl_nama = new System.Windows.Forms.Label();
            this.dashboard_button = new System.Windows.Forms.Button();
            this.progress_button = new System.Windows.Forms.Button();
            this.expenses_button = new System.Windows.Forms.Button();
            this.todo_button = new System.Windows.Forms.Button();
            this.lbl_expenses = new System.Windows.Forms.Label();
            this.lbl_todo1 = new System.Windows.Forms.Label();
            this.lbl_todo2 = new System.Windows.Forms.Label();
            this.lbl_income = new System.Windows.Forms.Label();
            this.lbl_outcome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_nama
            // 
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.lbl_nama.Font = new System.Drawing.Font("Aileron Heavy", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_nama.Location = new System.Drawing.Point(489, 52);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(0, 65);
            this.lbl_nama.TabIndex = 0;
            // 
            // dashboard_button
            // 
            this.dashboard_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dashboard_button.BackgroundImage")));
            this.dashboard_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dashboard_button.Location = new System.Drawing.Point(79, 31);
            this.dashboard_button.Name = "dashboard_button";
            this.dashboard_button.Size = new System.Drawing.Size(175, 176);
            this.dashboard_button.TabIndex = 1;
            this.dashboard_button.UseVisualStyleBackColor = true;
            // 
            // progress_button
            // 
            this.progress_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progress_button.BackgroundImage")));
            this.progress_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.progress_button.Location = new System.Drawing.Point(79, 225);
            this.progress_button.Name = "progress_button";
            this.progress_button.Size = new System.Drawing.Size(175, 176);
            this.progress_button.TabIndex = 2;
            this.progress_button.UseVisualStyleBackColor = true;
            this.progress_button.Click += new System.EventHandler(this.progress_button_Click);
            // 
            // expenses_button
            // 
            this.expenses_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("expenses_button.BackgroundImage")));
            this.expenses_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.expenses_button.Location = new System.Drawing.Point(79, 418);
            this.expenses_button.Name = "expenses_button";
            this.expenses_button.Size = new System.Drawing.Size(175, 176);
            this.expenses_button.TabIndex = 3;
            this.expenses_button.UseVisualStyleBackColor = true;
            this.expenses_button.Click += new System.EventHandler(this.expenses_button_Click);
            // 
            // todo_button
            // 
            this.todo_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("todo_button.BackgroundImage")));
            this.todo_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.todo_button.Location = new System.Drawing.Point(79, 611);
            this.todo_button.Name = "todo_button";
            this.todo_button.Size = new System.Drawing.Size(175, 176);
            this.todo_button.TabIndex = 4;
            this.todo_button.UseVisualStyleBackColor = true;
            this.todo_button.Click += new System.EventHandler(this.todo_button_Click);
            // 
            // lbl_expenses
            // 
            this.lbl_expenses.Image = ((System.Drawing.Image)(resources.GetObject("lbl_expenses.Image")));
            this.lbl_expenses.Location = new System.Drawing.Point(347, 139);
            this.lbl_expenses.Name = "lbl_expenses";
            this.lbl_expenses.Size = new System.Drawing.Size(620, 336);
            this.lbl_expenses.TabIndex = 5;
            this.lbl_expenses.Click += new System.EventHandler(this.lbl_expenses_Click);
            // 
            // lbl_todo1
            // 
            this.lbl_todo1.Font = new System.Drawing.Font("Aileron Heavy", 15F);
            this.lbl_todo1.ForeColor = System.Drawing.Color.White;
            this.lbl_todo1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_todo1.Image")));
            this.lbl_todo1.Location = new System.Drawing.Point(345, 516);
            this.lbl_todo1.Name = "lbl_todo1";
            this.lbl_todo1.Size = new System.Drawing.Size(290, 263);
            this.lbl_todo1.TabIndex = 6;
            this.lbl_todo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_todo1.Click += new System.EventHandler(this.lbl_todo1_Click);
            // 
            // lbl_todo2
            // 
            this.lbl_todo2.Font = new System.Drawing.Font("Aileron Heavy", 15F);
            this.lbl_todo2.ForeColor = System.Drawing.Color.White;
            this.lbl_todo2.Image = ((System.Drawing.Image)(resources.GetObject("lbl_todo2.Image")));
            this.lbl_todo2.Location = new System.Drawing.Point(648, 516);
            this.lbl_todo2.Name = "lbl_todo2";
            this.lbl_todo2.Size = new System.Drawing.Size(310, 263);
            this.lbl_todo2.TabIndex = 7;
            this.lbl_todo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_todo2.Click += new System.EventHandler(this.lbl_todo2_Click);
            // 
            // lbl_income
            // 
            this.lbl_income.BackColor = System.Drawing.Color.Transparent;
            this.lbl_income.Font = new System.Drawing.Font("Aileron Heavy", 30F);
            this.lbl_income.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_income.Location = new System.Drawing.Point(409, 291);
            this.lbl_income.Name = "lbl_income";
            this.lbl_income.Size = new System.Drawing.Size(207, 110);
            this.lbl_income.TabIndex = 8;
            this.lbl_income.Text = "-";
            this.lbl_income.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_income.Click += new System.EventHandler(this.lbl_income_Click);
            // 
            // lbl_outcome
            // 
            this.lbl_outcome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_outcome.Font = new System.Drawing.Font("Aileron Heavy", 30F);
            this.lbl_outcome.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_outcome.Location = new System.Drawing.Point(705, 291);
            this.lbl_outcome.Name = "lbl_outcome";
            this.lbl_outcome.Size = new System.Drawing.Size(211, 110);
            this.lbl_outcome.TabIndex = 9;
            this.lbl_outcome.Text = "-";
            this.lbl_outcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_outcome.Click += new System.EventHandler(this.lbl_outcome_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.label3.Location = new System.Drawing.Point(494, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 46);
            this.label3.TabIndex = 10;
            // 
            // main_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1675, 839);
            this.Controls.Add(this.lbl_nama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_outcome);
            this.Controls.Add(this.lbl_income);
            this.Controls.Add(this.lbl_todo2);
            this.Controls.Add(this.lbl_todo1);
            this.Controls.Add(this.lbl_expenses);
            this.Controls.Add(this.todo_button);
            this.Controls.Add(this.expenses_button);
            this.Controls.Add(this.progress_button);
            this.Controls.Add(this.dashboard_button);
            this.Font = new System.Drawing.Font("Aileron Heavy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "main_frm";
            this.Text = "Main Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_frm_FormClosing);
            this.Load += new System.EventHandler(this.main_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button dashboard_button;
        private System.Windows.Forms.Button progress_button;
        private System.Windows.Forms.Button expenses_button;
        private System.Windows.Forms.Button todo_button;
        private System.Windows.Forms.Label lbl_expenses;
        private System.Windows.Forms.Label lbl_todo1;
        private System.Windows.Forms.Label lbl_todo2;
        private System.Windows.Forms.Label lbl_income;
        private System.Windows.Forms.Label lbl_outcome;
        public System.Windows.Forms.Label lbl_nama;
        private System.Windows.Forms.Label label3;
    }
}