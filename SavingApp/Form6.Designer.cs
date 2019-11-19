namespace SavingApp
{
    partial class add_expensesfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_expensesfrm));
            this.radio_income = new System.Windows.Forms.RadioButton();
            this.radio_outcome = new System.Windows.Forms.RadioButton();
            this.amount_txt = new System.Windows.Forms.TextBox();
            this.info_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.submit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radio_income
            // 
            this.radio_income.AutoSize = true;
            this.radio_income.BackColor = System.Drawing.Color.Transparent;
            this.radio_income.Location = new System.Drawing.Point(117, 469);
            this.radio_income.Name = "radio_income";
            this.radio_income.Size = new System.Drawing.Size(14, 13);
            this.radio_income.TabIndex = 0;
            this.radio_income.TabStop = true;
            this.radio_income.UseVisualStyleBackColor = false;
            // 
            // radio_outcome
            // 
            this.radio_outcome.AutoSize = true;
            this.radio_outcome.BackColor = System.Drawing.Color.Transparent;
            this.radio_outcome.Location = new System.Drawing.Point(275, 469);
            this.radio_outcome.Name = "radio_outcome";
            this.radio_outcome.Size = new System.Drawing.Size(14, 13);
            this.radio_outcome.TabIndex = 1;
            this.radio_outcome.TabStop = true;
            this.radio_outcome.UseVisualStyleBackColor = false;
            // 
            // amount_txt
            // 
            this.amount_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amount_txt.Font = new System.Drawing.Font("Aileron Heavy", 25F);
            this.amount_txt.Location = new System.Drawing.Point(99, 201);
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.Size = new System.Drawing.Size(293, 40);
            this.amount_txt.TabIndex = 2;
            // 
            // info_txt
            // 
            this.info_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.info_txt.Font = new System.Drawing.Font("Aileron Heavy", 25F);
            this.info_txt.Location = new System.Drawing.Point(99, 296);
            this.info_txt.Name = "info_txt";
            this.info_txt.Size = new System.Drawing.Size(293, 40);
            this.info_txt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(116)))), ((int)(((byte)(107)))));
            this.label1.Font = new System.Drawing.Font("Aileron Heavy", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Amount : ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(116)))), ((int)(((byte)(107)))));
            this.label2.Font = new System.Drawing.Font("Aileron Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(88, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Info :";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(116)))), ((int)(((byte)(107)))));
            this.label3.Font = new System.Drawing.Font("Aileron Heavy", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(88, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Aileron Heavy", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(100, 407);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(292, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // submit_button
            // 
            this.submit_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("submit_button.BackgroundImage")));
            this.submit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.submit_button.Font = new System.Drawing.Font("Aileron Heavy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_button.Location = new System.Drawing.Point(168, 517);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(140, 56);
            this.submit_button.TabIndex = 9;
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // add_expensesfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(506, 646);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.info_txt);
            this.Controls.Add(this.amount_txt);
            this.Controls.Add(this.radio_outcome);
            this.Controls.Add(this.radio_income);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "add_expensesfrm";
            this.Text = "Add your expenses";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.add_expensesfrm_FormClosing);
            this.Load += new System.EventHandler(this.add_expensesfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio_income;
        private System.Windows.Forms.RadioButton radio_outcome;
        private System.Windows.Forms.TextBox amount_txt;
        private System.Windows.Forms.TextBox info_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button submit_button;
    }
}