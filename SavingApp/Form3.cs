using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace SavingApp
{
    public partial class signin_frm : Form
    { 
        static SqlDataAdapter da;
        static SqlDataReader dr;
        static DataTable dt;
        static SqlCommand cmd;
        private static bool _exiting;
        public signin_frm()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ImeMode = ImeMode.NoControl;
            InitializeComponent();           
        }

        private void signin_button_Click(object sender, EventArgs e)
        {
            string syntax = "SELECT * FROM login_database WHERE username= '" + username_txt.Text + "'";
            da = new SqlDataAdapter(syntax, Program.database);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Username is already TAKEN find the single one", "Invalid username, what you expect ?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string syntax2 = "INSERT INTO login_database (username,pass,nama_user,target,duration) VALUES (@val1,@val2,@val3,@val4,@val5)";//@valn for security
            cmd = new SqlCommand();
            cmd.Connection = Program.database;
            cmd.CommandText = syntax2;
            cmd.Parameters.AddWithValue("@val1", username_txt.Text); //prevent some shit gonna happen with using SQL injection in text box
            cmd.Parameters.AddWithValue("@val2", pass_txt.Text);
            cmd.Parameters.AddWithValue("@val3", name_txt.Text);
            cmd.Parameters.AddWithValue("@val4", target_txt.Text);
            cmd.Parameters.AddWithValue("@val5", datepicker.Value);
            Program.database.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Succesfully registered !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Program.database.Close();
            this.Hide();
            Program.login.Show();
        }

        private void signin_frm_Load(object sender, EventArgs e)
        {
            pass_txt.UseSystemPasswordChar=true;
        }

        private void signin_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_exiting && MessageBox.Show("Are you really want to exit ?", "Exit ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                _exiting = true;
                Environment.Exit(1);
            }
        }
    }
}
