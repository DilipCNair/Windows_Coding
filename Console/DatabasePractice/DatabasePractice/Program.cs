using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ActivationStatus = true;
            bool AdminAccountStatus = true;
            string UserName ="Dilip";
            string Password = "Dilip";
            SqlConnection Connection = new SqlConnection();
            SqlCommand Command = new SqlCommand();
            SqlConnectionStringBuilder ConnectionStringBuilder = new SqlConnectionStringBuilder();
            SqlDataReader RowReader;
            SqlDataAdapter Adapter;
            string QuerryRegister;
            string QuerryAuthenticate;
            bool? ActivationStatus_fromDB =null, AdminAccountStatus_fromdb = null;
            string  Username_fromdb=null, Password_fromdb = null;


            //Initializing Query Strings
            QuerryAuthenticate = "Select * from [RBS_Authentication]";
            QuerryRegister = "Insert into [RBS_Authentication]([Activation Status],[Admin Account Status],[User Name],[Password]) values(@ActivationStatus,@AdminAccountStatus,@Username,@Password)";

            //Building the Connection String and Assigning to Connection
            ConnectionStringBuilder.Encrypt = true;
            ConnectionStringBuilder.TrustServerCertificate = true;
            ConnectionStringBuilder.DataSource = "DILIPC";
            ConnectionStringBuilder.InitialCatalog = "Secure_Database";
            ConnectionStringBuilder.UserID = "sa";
            ConnectionStringBuilder.Password = "SQLserver!1";

            //Assigning Connection String Builder to Connection Object
            Connection.ConnectionString = ConnectionStringBuilder.ToString();

            //Building the Command
            Command.Connection = Connection;
            Command.Parameters.Add(new SqlParameter("@ActivationStatus", ActivationStatus));
            Command.Parameters.Add(new SqlParameter("@AdminAccountStatus", AdminAccountStatus));
            Command.Parameters.Add(new SqlParameter("@Username", UserName));
            Command.Parameters.Add(new SqlParameter("@Password", Password));

            //Executing the Command
            Connection.Open();
            //Command.CommandText = QuerryRegister;
            //Command.ExecuteNonQuery();
            Command.CommandText = QuerryAuthenticate;
            using (RowReader = Command.ExecuteReader())
            {
                while (RowReader.Read())
                {
                    ActivationStatus_fromDB = RowReader.GetBoolean(RowReader.GetOrdinal("Activation Status"));
                    AdminAccountStatus_fromdb = RowReader.GetBoolean(RowReader.GetOrdinal("Admin Account Status"));
                    Username_fromdb = RowReader["User Name"].ToString();
                    Password_fromdb = RowReader["Password"].ToString();
                }
            }
            Console.WriteLine(ActivationStatus_fromDB.ToString() + AdminAccountStatus_fromdb + Username_fromdb + Password_fromdb);
            Connection.Close();
            //Console.WriteLine(ActivationStatus_fromDB);
            //Console.WriteLine(AdminAccountStatus_fromdb);
            //Console.WriteLine(Username_fromdb + "\n"+ Password_fromdb);


            //switch (ActivationStatus_fromDB)
            //{
            //    case false:
            //        ActivationStatus = true;
            //        LoadRegistrationView();
            //        break;

            //    case true:
            //        switch (AdminAccountStatus_fromdb)
            //        {
            //            case false:
            //                LoadRegistrationView();
            //                break;
            //            case true:
            //                LoadLoginView();
            //                break;
            //            default:
            //                break;
            //        }
            //        break;
            //    default: break;

            //}
            Console.ReadKey();
        }

        public static void LoadRegistrationView()
        {
            Console.Write("RegistrationView");
        }

        public static void LoadLoginView()
        {
            Console.Write("LoginView");
        }
    }
}
