using Microsoft.Data.SqlClient;
using MVVMTask.Model;
using System.Windows;

namespace MVVMTask.ViewModel
{
    public class HomeViewModel
    {
        public Student StudentValue { get; set; }

        public Eventcommad Createaccount {  get; set; }

        public HomeViewModel() 
        {
            Createaccount = new Eventcommad(Register);
            if (StudentValue == null )
            {
                StudentValue = new Student();
            }
            StudentValue.Name = "sathish";
            StudentValue.Age = 18;
            StudentValue.Location = "Vellore";

        }
        public void Register()
        {
            string name = StudentValue.Name;
            int age= StudentValue.Age;
            string location = StudentValue.Location;
            //sqlconnection
            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=OCT05;Data Source=DESKTOP-2MPHQ9B\\SQLEXPRESS;Encrypt=false;";
            sql.Open();
            //string create = $"Create Table MVVM(Name Nvarchar(20),Age Numeric(20),Location Nvarchar(20))";
            string insert = $"Insert into MVVM Values('{name}','{age}','{location}')";
            SqlCommand sqlCommand=new SqlCommand(insert, sql);
            sqlCommand.Connection = sql;
            object val= sqlCommand.ExecuteNonQuery();
            sql.Close();

            MessageBox.Show("Reg Success");
        }
    }
}
