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
    public partial class Add_todo_list : Form
    {
        static SqlDataAdapter da;
        static SqlDataReader dr;
        static DataTable dt;
        static SqlCommand cmd;
        private static bool _exiting;
        public Add_todo_list()
        {
            InitializeComponent();
        }

        private void Add_todo_list_Load(object sender, EventArgs e)
        {

        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source=TOÅSTMALÖNEROG;Initial Catalog = SavingApps;Integrated Security = SSPI;";
            string query = "INSERT INTO todo_list(info,status,username) VALUES (@val1,@val2,@val3)";
            Program.database = new SqlConnection(connection);
            cmd = new SqlCommand();
            cmd.Connection = Program.database;
            cmd.CommandText = query;
            string status = "In progress";
            cmd.Parameters.AddWithValue("@val1", txt_input.Text);
            cmd.Parameters.AddWithValue("@val2", status);
            cmd.Parameters.AddWithValue("@val3", Program.login.username);
            Program.database.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Succesfully added", "Success BOI !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Program.database.Close();
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
