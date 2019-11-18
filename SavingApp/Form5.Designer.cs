namespace SavingApp
{
    partial class to_do_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(to_do_frm));
            this.todo_button = new System.Windows.Forms.Button();
            this.expenses_button = new System.Windows.Forms.Button();
            this.progress_button = new System.Windows.Forms.Button();
            this.dashboard_button = new System.Windows.Forms.Button();
            this.lv_1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.add_button = new System.Windows.Forms.Button();
            this.done_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // todo_button
            // 
            this.todo_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("todo_button.BackgroundImage")));
            this.todo_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.todo_button.Location = new System.Drawing.Point(76, 610);
            this.todo_button.Name = "todo_button";
            this.todo_button.Size = new System.Drawing.Size(175, 176);
            this.todo_button.TabIndex = 8;
            this.todo_button.UseVisualStyleBackColor = true;
            // 
            // expenses_button
            // 
            this.expenses_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("expenses_button.BackgroundImage")));
            this.expenses_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.expenses_button.Location = new System.Drawing.Point(76, 417);
            this.expenses_button.Name = "expenses_button";
            this.expenses_button.Size = new System.Drawing.Size(175, 176);
            this.expenses_button.TabIndex = 7;
            this.expenses_button.UseVisualStyleBackColor = true;
            this.expenses_button.Click += new System.EventHandler(this.expenses_button_Click);
            // 
            // progress_button
            // 
            this.progress_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progress_button.BackgroundImage")));
            this.progress_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.progress_button.Location = new System.Drawing.Point(76, 224);
            this.progress_button.Name = "progress_button";
            this.progress_button.Size = new System.Drawing.Size(175, 176);
            this.progress_button.TabIndex = 6;
            this.progress_button.UseVisualStyleBackColor = true;
            this.progress_button.Click += new System.EventHandler(this.progress_button_Click);
            // 
            // dashboard_button
            // 
            this.dashboard_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dashboard_button.BackgroundImage")));
            this.dashboard_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dashboard_button.Location = new System.Drawing.Point(76, 30);
            this.dashboard_button.Name = "dashboard_button";
            this.dashboard_button.Size = new System.Drawing.Size(175, 176);
            this.dashboard_button.TabIndex = 5;
            this.dashboard_button.UseVisualStyleBackColor = true;
            this.dashboard_button.Click += new System.EventHandler(this.dashboard_button_Click);
            // 
            // lv_1
            // 
            this.lv_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(78)))), ((int)(((byte)(219)))));
            this.lv_1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lv_1.Font = new System.Drawing.Font("Aileron Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_1.ForeColor = System.Drawing.Color.White;
            this.lv_1.GridLines = true;
            this.lv_1.HideSelection = false;
            this.lv_1.Location = new System.Drawing.Point(348, 137);
            this.lv_1.Name = "lv_1";
            this.lv_1.Size = new System.Drawing.Size(627, 638);
            this.lv_1.TabIndex = 9;
            this.lv_1.UseCompatibleStateImageBehavior = false;
            this.lv_1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Information";
            this.columnHeader1.Width = 367;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Status";
            this.columnHeader2.Width = 256;
            // 
            // lv_2
            // 
            this.lv_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(116)))), ((int)(((byte)(107)))));
            this.lv_2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lv_2.Font = new System.Drawing.Font("Aileron Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_2.ForeColor = System.Drawing.Color.White;
            this.lv_2.GridLines = true;
            this.lv_2.HideSelection = false;
            this.lv_2.Location = new System.Drawing.Point(1030, 137);
            this.lv_2.Name = "lv_2";
            this.lv_2.Size = new System.Drawing.Size(627, 638);
            this.lv_2.TabIndex = 10;
            this.lv_2.UseCompatibleStateImageBehavior = false;
            this.lv_2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Information";
            this.columnHeader3.Width = 426;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Status";
            this.columnHeader4.Width = 197;
            // 
            // add_button
            // 
            this.add_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_button.BackgroundImage")));
            this.add_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_button.Font = new System.Drawing.Font("Aileron Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Location = new System.Drawing.Point(1580, 54);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(77, 77);
            this.add_button.TabIndex = 11;
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // done_button
            // 
            this.done_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("done_button.BackgroundImage")));
            this.done_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.done_button.Location = new System.Drawing.Point(1493, 55);
            this.done_button.Name = "done_button";
            this.done_button.Size = new System.Drawing.Size(72, 73);
            this.done_button.TabIndex = 12;
            this.done_button.UseVisualStyleBackColor = true;
            this.done_button.Click += new System.EventHandler(this.done_button_Click);
            // 
            // to_do_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1721, 811);
            this.Controls.Add(this.done_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.lv_2);
            this.Controls.Add(this.lv_1);
            this.Controls.Add(this.todo_button);
            this.Controls.Add(this.expenses_button);
            this.Controls.Add(this.progress_button);
            this.Controls.Add(this.dashboard_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "to_do_frm";
            this.Text = "To-Do List";
            this.Load += new System.EventHandler(this.to_do_frm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button todo_button;
        private System.Windows.Forms.Button expenses_button;
        private System.Windows.Forms.Button progress_button;
        private System.Windows.Forms.Button dashboard_button;
        private System.Windows.Forms.ListView lv_1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lv_2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button done_button;
    }
}