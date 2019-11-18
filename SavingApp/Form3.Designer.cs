namespace SavingApp
{
    partial class signin_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signin_frm));
            this.username_txt = new System.Windows.Forms.TextBox();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.target_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.signin_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_txt
            // 
            this.username_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_txt.Location = new System.Drawing.Point(699, 313);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(309, 39);
            this.username_txt.TabIndex = 5;
            // 
            // pass_txt
            // 
            this.pass_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_txt.Location = new System.Drawing.Point(699, 410);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(309, 39);
            this.pass_txt.TabIndex = 6;
            // 
            // target_txt
            // 
            this.target_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.target_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.target_txt.Location = new System.Drawing.Point(699, 508);
            this.target_txt.Name = "target_txt";
            this.target_txt.Size = new System.Drawing.Size(309, 39);
            this.target_txt.TabIndex = 7;
            // 
            // name_txt
            // 
            this.name_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt.Location = new System.Drawing.Point(699, 216);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(309, 39);
            this.name_txt.TabIndex = 4;
            // 
            // datepicker
            // 
            this.datepicker.CalendarForeColor = System.Drawing.Color.Black;
            this.datepicker.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.datepicker.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.datepicker.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.datepicker.CustomFormat = "MM/yyyy";
            this.datepicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepicker.Location = new System.Drawing.Point(746, 602);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(214, 46);
            this.datepicker.TabIndex = 10;
            // 
            // signin_button
            // 
            this.signin_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signin_button.BackgroundImage")));
            this.signin_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.signin_button.Location = new System.Drawing.Point(790, 675);
            this.signin_button.Name = "signin_button";
            this.signin_button.Size = new System.Drawing.Size(132, 50);
            this.signin_button.TabIndex = 11;
            this.signin_button.UseVisualStyleBackColor = true;
            this.signin_button.Click += new System.EventHandler(this.signin_button_Click);
            // 
            // signin_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1721, 811);
            this.Controls.Add(this.signin_button);
            this.Controls.Add(this.datepicker);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.target_txt);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.username_txt);
            this.Name = "signin_frm";
            this.Text = "Sign In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.signin_frm_FormClosing);
            this.Load += new System.EventHandler(this.signin_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.TextBox target_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.DateTimePicker datepicker;
        private System.Windows.Forms.Button signin_button;
    }
}