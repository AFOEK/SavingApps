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
    public partial class expenses_frm : Form
    {
        static SqlConnection database;
        static SqlDataAdapter da;
        static SqlDataReader dr;
        static DataTable dt;
        static SqlCommand cmd;
        private static bool _exiting;
        public expenses_frm()
        {
            InitializeComponent();
            listView1.FullRowSelect = true;
        }
        void loaddata()
        {
            try
            {
                database = new SqlConnection(
                @"Data Source=TOÅSTMALÖNEROG;
                Initial Catalog=SavingApps;
                Integrated Security=SSPI;");
                string syntax = "SELECT * FROM expenses where username='" + Program.login.username + "';";
                database.Open();
                cmd = new SqlCommand();
                cmd.Connection = database;
                cmd.CommandText = syntax;
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem lt = new ListViewItem(dr["date_due"].ToString());
                    lt.SubItems.Add(dr["info"].ToString());
                    lt.SubItems.Add(dr["income"].ToString());
                    lt.SubItems.Add(dr["outcome"].ToString());
                    listView1.Items.Add(lt);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void expenses_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_exiting && MessageBox.Show("Are you really want to exit ?", "Exit ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                _exiting = true;
                Environment.Exit(1);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            add_expensesfrm add = new add_expensesfrm();
            this.Show();
            add.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main_frm main = new main_frm();
            this.Hide();
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progress_frm progress = new progress_frm();
            this.Hide();
            progress.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            expenses_frm expenses = new expenses_frm();
            this.Hide();
            expenses.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            to_do_frm todo = new to_do_frm();
            this.Hide();
            todo.Show();
        }

        private void expenses_frm_Load(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
