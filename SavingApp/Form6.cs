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
    public partial class add_expensesfrm : Form
    {
        static SqlDataAdapter da;
        static SqlDataReader dr;
        static DataTable dt;
        static SqlCommand cmd;
        private static bool _exiting;
        public add_expensesfrm()
        {
            InitializeComponent();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {

            string syntax_income = "INSERT INTO expenses (date_due,info,income,outcome,username) VALUES (@val1,@val2,@val3,@val4,@val5);";
            string syntax_outcome = "INSERT INTO expenses (date_due,info,outcome,income,username) VALUES (@val1,@val2,@val3,@val4,@val5);";
            cmd = new SqlCommand();
            cmd.Connection = Program.database;
            if (radio_income.Checked == true)
            {
                cmd.CommandText = syntax_income;
                cmd.Parameters.AddWithValue("@val3", amount_txt.Text);
                cmd.Parameters.AddWithValue("@val2", info_txt.Text);
                cmd.Parameters.AddWithValue("@val1", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@val4", DBNull.Value);
                cmd.Parameters.AddWithValue("@val5", Program.login.username);
                Program.database.Open();
                cmd.ExecuteNonQuery();
                Program.database.Close();
                if(MessageBox.Show("Succesfully add", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)==DialogResult.OK)
                {
                    Program.expenses.listView1.Items.Clear();
                    Program.expenses.loaddata();
                    Program.database.Close();
                    this.Hide();
                    Program.expenses.Show();
                }  
            }
            if (radio_outcome.Checked == true)
            {
                cmd.CommandText = syntax_outcome;
                cmd.Parameters.AddWithValue("@val3", amount_txt.Text);
                cmd.Parameters.AddWithValue("@val2", info_txt.Text);
                cmd.Parameters.AddWithValue("@val1", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@val4", DBNull.Value);
                cmd.Parameters.AddWithValue("@val5", Program.login.username);
                Program.database.Open();
                cmd.ExecuteNonQuery();
                Program.database.Close();
                if (MessageBox.Show("Succesfully add", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    Program.expenses.listView1.Items.Clear();
                    Program.expenses.loaddata();
                    Program.database.Close();
                    this.Hide();
                    Program.expenses.Show();
                }
            }
        }

        private void add_expensesfrm_Load(object sender, EventArgs e)
        {

        }

        private void add_expensesfrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_exiting && MessageBox.Show("Are you really want to exit ?", "Exit ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                _exiting = true;
                Environment.Exit(1);
            }
        }
    }
}
