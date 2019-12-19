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

namespace SavingApp
{
    public partial class progress_frm : Form
    {
        static SqlDataReader dr0;
        static SqlDataReader dr;
        static SqlDataReader dr1;
        static SqlDataAdapter da;
        static DataTable dt;
        static DataTable dt2;
        static SqlDataAdapter da2;
        static SqlCommand cmd;
        static SqlCommand cmd2;
        private static bool _exiting;
        public progress_frm()
        {
            InitializeComponent();
        }
        public void loaddata()
        {
            string nilai = "0";
            string syntax0 = "SELECT target FROM login_database where username='" + Program.login.username + "';";
            Program.database.Open();
            cmd = new SqlCommand(syntax0, Program.database);
            dr0 = cmd.ExecuteReader();
            while (dr0.Read())
            {
                nilai = dr0["target"].ToString();
            }
            progressBar1.Maximum = int.Parse(nilai);
            progressBar1.Minimum = 0;
            timer.Start();
            dr0.Close();
            Program.database.Close();

            string income="0", outcome="0";
            int hasiltot=0;
            Program.database.Open();
            string syntax = "select SUM(income) from expenses where username='"+Program.main.lbl_nama.Text+"'";
            cmd = new SqlCommand(syntax,Program.database);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                income = dr[0].ToString();
            }
            cmd.Dispose();
            dr.Close();
            string syntax2 = "select SUM(outcome) from expenses where username='" + Program.main.lbl_nama.Text + "'";
            cmd2 = new SqlCommand(syntax2, Program.database);
            dr1 = cmd.ExecuteReader();
            while (dr1.Read())
            {
                outcome = dr1[0].ToString();
            }
            dr1.Close();
            Program.database.Close();

            hasiltot = int.Parse(income) - int.Parse(outcome);
            progressBar1.Value = hasiltot;
            lbl_total.Text = hasiltot.ToString();
            progressBar1.Value = progressBar1.Minimum;
            label1.Left = 0;
            timer.Enabled = true;
        }
        private void progress_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_exiting && MessageBox.Show("Are you really want to exit ?", "Exit ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                _exiting = true;
                Environment.Exit(1);
            }
        }

        private void progress_frm_Load(object sender, EventArgs e)
        {     
            loaddata();
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value ++;
                label1.Left = progressBar1.Value;
            }
            else
            {
                timer.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.progress.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.expenses.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.to_Do.Show();
        }
    }
}
