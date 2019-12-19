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
    public partial class login_frm : Form
    {
        static SqlDataAdapter da;
        static SqlDataReader dr;
        static DataTable dt;
        static SqlCommand cmd;
        private static bool _exiting;
        public string username;

        public login_frm()
        {
            InitializeComponent();
        }

        private void login_frm_Load(object sender, EventArgs e)
        {
            txt_pass.UseSystemPasswordChar = true;//hide your typed password to SQL   
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Program.signin.Show();
        }

        private void Login_butt_Click(object sender, EventArgs e)
        {
            Program.database.Open();
            string syntax = "SELECT * FROM login_database WHERE username='" + txt_id.Text + "'AND pass='" + txt_pass.Text + "'";
            da = new SqlDataAdapter(syntax, Program.database);
            dt = new DataTable();
            da.Fill(dt);

            username = txt_id.Text;
            string syntax2 = "SELECT nama_user FROM login_database WHERE username='" + username + "'";
            cmd = new SqlCommand(syntax2, Program.database);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Program.main.lbl_nama.Text = dr["nama_user"].ToString();
            }
            dr.Close();

            string query = "SELECT username from login_database where username='root' and pass='toor'";
            da = new SqlDataAdapter(query, Program.database);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                Program.database.Close();
                Program.Crystal.Show();
            }

            if (dt.Rows.Count == 1)
            {
                this.Hide();
                Program.database.Close();
                Program.main.Show();
            }
            Program.database.Close();
        }

        private void login_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_exiting && MessageBox.Show("Are you really want to exit ?", "Exit ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                _exiting = true;
                Environment.Exit(1);
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void login_frm_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }
    }
}
