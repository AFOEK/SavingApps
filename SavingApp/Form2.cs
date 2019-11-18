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
    public partial class main_frm : Form
    {
        static SqlDataAdapter da;
        static SqlDataAdapter da2;
        static SqlDataAdapter da3;
        static DataTable dt;
        static DataTable dt2;
        static DataTable dt3;
        static SqlCommand cmd;
        static SqlCommand cmd1;
        static SqlCommand cmd2;
        private static bool _exiting;
        
        public main_frm()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ImeMode = ImeMode.NoControl;
            InitializeComponent();
        }
        private void main_frm_Load(object sender, EventArgs e)
        {
            string syntax = "SELECT MAX (outcome) as outmax, MAX (income) as inmax FROM expenses where username='" + Program.login.username + "'";
            string syntax2 = "SELECT TOP (1) [info] as infodone from todo_list where status = 'Done' AND username='" + Program.login.username + "'";
            string syntax3 = "SELECT TOP (1) [info] as infoinprogress from todo_list where status = 'In Progress' AND username='" + Program.login.username + "'";
            Program.database.Open();
            cmd = new SqlCommand(syntax, Program.database);
            cmd1 = new SqlCommand(syntax2, Program.database);
            cmd2 = new SqlCommand(syntax3, Program.database);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            DataRow dr;
            for(int i=0;i<dt.Rows.Count;i++)
            {
                dr = dt.Rows[i];
                lbl_outcome.Text = dr["outmax"].ToString();
                lbl_income.Text = dr["inmax"].ToString();
            }
            da2 = new SqlDataAdapter(cmd1);
            dt2 = new DataTable();
            da2.Fill(dt2);
            for(int i=0;i<dt.Rows.Count;i++)
            {
                dr = dt2.Rows[i];
                lbl_todo1.Text = dr["infodone"].ToString();
            }
            da3 = new SqlDataAdapter(cmd2);
            dt3 = new DataTable();
            da3.Fill(dt3);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dr = dt3.Rows[i];
                lbl_todo2.Text = dr["infoinprogress"].ToString();
            }
            Program.database.Close();
        }
        private void progress_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.progress.Show();
        }

        private void expenses_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.expenses.Show();
        }

        private void todo_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.to_Do.Show();
        }

        private void lbl_expenses_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.expenses.Show();
        }

        private void main_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_exiting && MessageBox.Show("Are you really want to exit ?", "Exit ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                _exiting = true;
                Environment.Exit(1);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.expenses.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.expenses.Show();
        }

        private void lbl_income_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.expenses.Show();
        }

        private void lbl_outcome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.expenses.Show();
        }

        private void lbl_todo1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.to_Do.Show();
        }

        private void lbl_todo2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.to_Do.Show();
        }
    }
}
