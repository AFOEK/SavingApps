using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SavingApp
{
    public partial class to_do_frm : Form
    {
        static SqlDataAdapter da;
        static SqlDataReader dr;
        static DataTable dt;
        static SqlCommand cmd;
        private static bool _exiting;

        public to_do_frm()
        {
            InitializeComponent();
            lv_1.FullRowSelect = true;
            lv_2.FullRowSelect = true;
        }
        public void loaddata()
        {
            string query = "SELECT info, status FROM todo_list WHERE status='In Progress' and username='" + Program.login.username + "';";
            Program.database.Open();

            cmd= Program.database.CreateCommand();
            cmd.CommandText = query;
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem lt = new ListViewItem(dr["info"].ToString());
                lt.SubItems.Add(dr["status"].ToString());
                lv_1.Items.Add(lt);
            }

            string query2 = "SELECT info, status FROM todo_list WHERE status='Done'and username='" + Program.login.username + "';";
            cmd = new SqlCommand();
            cmd.Connection = Program.database;
            cmd.CommandText = query2;
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem lt = new ListViewItem(dr["info"].ToString());
                lt.SubItems.Add(dr["status"].ToString());
                lv_2.Items.Add(lt);
            }
            Program.database.Close();
        }
        private void dashboard_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.main.Show();
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

        private void add_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.add_Todo.Show();
        }

        private void to_do_frm_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void done_button_Click(object sender, EventArgs e)
        {
            string query = "UPDATE todo_list SET status = 'Done' WHERE info='" + lv_1.SelectedItems[0].Text + "';";
            Program.database.Open();
            cmd = new SqlCommand(query, Program.database);
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {

            }
            dr.Close();
            Program.database.Close();
            lv_1.Items.Clear();
            lv_2.Items.Clear();
            loaddata();
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
