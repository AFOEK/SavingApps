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
        static SqlDataReader dr;
        static SqlDataAdapter da;
        static DataTable dt;
        static SqlCommand cmd;
        private static bool _exiting;
        public progress_frm()
        {
            InitializeComponent();
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
            string nilai = "0";
            string syntax = "SELECT target FROM login_database where username='" + Program.login.username + "';";
            Program.database.Open();
            cmd = new SqlCommand(syntax,Program.database);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nilai = dr["target"].ToString();
            }
            progressBar1.Maximum = int.Parse(nilai);
            timer.Start();
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
                label1.Left = progressBar1.Value;
            }
            else timer.Stop();
        }
    }
}
