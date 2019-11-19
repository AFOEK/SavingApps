namespace SavingApp
{
    partial class login_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_frm));
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Login_butt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id.Location = new System.Drawing.Point(695, 381);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(312, 39);
            this.txt_id.TabIndex = 2;
            // 
            // txt_pass
            // 
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass.Location = new System.Drawing.Point(695, 488);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(312, 39);
            this.txt_pass.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(708, 548);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "New  here ?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkLabel1.Location = new System.Drawing.Point(789, 548);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(86, 15);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign up here !!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Login_butt
            // 
            this.Login_butt.BackColor = System.Drawing.Color.Transparent;
            this.Login_butt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Login_butt.BackgroundImage")));
            this.Login_butt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Login_butt.ForeColor = System.Drawing.Color.Transparent;
            this.Login_butt.Location = new System.Drawing.Point(783, 593);
            this.Login_butt.Name = "Login_butt";
            this.Login_butt.Size = new System.Drawing.Size(141, 54);
            this.Login_butt.TabIndex = 6;
            this.Login_butt.UseVisualStyleBackColor = false;
            this.Login_butt.Click += new System.EventHandler(this.Login_butt_Click);
            // 
            // login_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1709, 811);
            this.Controls.Add(this.Login_butt);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_id);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Aileron Heavy", 24F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.MaximizeBox = false;
            this.Name = "login_frm";
            this.Text = "Log In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.login_frm_FormClosing);
            this.Load += new System.EventHandler(this.login_frm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_frm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button Login_butt;
        public System.Windows.Forms.TextBox txt_id;
    }
}

