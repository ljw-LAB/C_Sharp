using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace ex_179
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        string connStr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\study\C#\Study\Textbook3\Part4\ex_179\Login.mdf; Integrated Security = True";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                if(conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                string sql = string.Format("SELECT COUNT(*) FROM LoginTable " + "WHERE UserName = '{0}' AND Password='{1}'", txtUserName.Text, txtPassword.Password);
                SqlCommand comm = new SqlCommand(sql, conn);
                int count = Convert.ToInt32(comm.ExecuteScalar());
                if (count == 1)
                {
                    MessageBox.Show("Login 성공");
                }
                else
                {
                    MessageBox.Show("Login 실패");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
