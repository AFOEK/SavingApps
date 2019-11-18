using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SavingApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static login_frm login;
        public static signin_frm signin;
        public static to_do_frm to_Do;
        public static main_frm main;
        public static add_expensesfrm Add_Expenses;
        public static Add_todo_list add_Todo;
        public static progress_frm progress;
        public static expenses_frm expenses;
        public static About_frm about;
        public static SqlConnection database;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SqlConnection database = new SqlConnection(
            @"Data Source=TOÅSTMALÖNEROG;
            Initial Catalog=SavingApps;
            Integrated Security=SSPI;");
            //signin_frm signin = new signin_frm();
            //to_do_frm to_Do = new to_do_frm();
            //main_frm main = new main_frm();
            //add_expensesfrm Add_Expenses = new add_expensesfrm();
            //Add_todo_list add_Todo = new Add_todo_list();
            //progress_frm progress = new progress_frm();
            //expenses_frm expenses = new expenses_frm();
            //About_frm about = new About_frm();
            //login_frm login = new login_frm();
            signin = new signin_frm();
            to_Do = new to_do_frm();
            main = new main_frm();
            Add_Expenses = new add_expensesfrm();
            add_Todo = new Add_todo_list();
            progress = new progress_frm();
            expenses = new expenses_frm();
            about = new About_frm();
            login = new login_frm();
            Application.Run(login);
            //Application.Run(new login_frm());
        }
    }
}
