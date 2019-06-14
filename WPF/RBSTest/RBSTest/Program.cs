using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBSTest
{
    class Program
    {
        static void Main(string[] args)
        {
            AuthenticationSystem AuthenticationSystemObject = new AuthenticationSystem();
            AuthenticationSystemObject.FullName = "Dilip-";
            AuthenticationSystemObject.MasterPassword = "Password";
            AuthenticationSystemObject.EmployeeID = "15mcei05";
            AuthenticationSystemObject.EmailID = "dilipn6@gmail.com";
            AuthenticationSystemObject.AdminAccountStatus = true;
            AuthenticationSystemObject.ActivationStatus = true;
            AuthenticationSystemObject.CreateAdminAccount();
            Console.ReadKey();
        }
    }
}
