using System;
using System.Collections.Generic;

namespace Delegates
{
    delegate bool IsPromotable(employee empl);

    class Program
    {
        public static void Main()
        {
            List<employee> emplist = new List<employee>();
            emplist.Add(new employee() { ID = 101, Name = "Dilip", Salary = 5000, Experience = 5 });
            emplist.Add(new employee() { ID = 102, Name = "Sethu", Salary = 7000, Experience = 7 });
            emplist.Add(new employee() { ID = 103, Name = "Nakul", Salary = 4000, Experience = 4 });
            emplist.Add(new employee() { ID = 104, Name = "Aaditya", Salary = 3000, Experience = 3 });

            IsPromotable promotable = new IsPromotable(promote);
            employee.PromoteEmployee(emplist, promotable);
            Console.ReadKey();
            
        }
        public static bool promote(employee emp)
        {
            if (emp.Experience>=5)
                return true;
            else
                return false;
        }
    }

    class employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set;}

        public static void PromoteEmployee(List<employee> employeelist, IsPromotable IsElligibleToPromote)
        {
            foreach(employee emp in employeelist )
            {
                if(IsElligibleToPromote(emp))
                {
                    Console.WriteLine(emp.Name + " Promoted");
                }
            }
        }
    }
    }
