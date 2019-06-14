using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
namespace Log_Reader
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.Clear();
                File.WriteAllText(@"F:\Programming Projects\Visual Studio\Visual C#\Key Logger\Key Logger\bin\Debug\log.txt", String.Empty);
                Console.Write("\n\t\t\t Intrusion Detection System\n\n ****** Menu ******\n\n 1). Train the IDS\n\n 2). Check with IDS\n\n 3). Exit\n\n --->Enter Your Choice : ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Train();
                        break;
                    case 2:
                        Check();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Write("\n Wrong Choice");
                        break;
                }
            } while (choice != 3);
        }

        public static void Train()
        {
            int count = 0;
            SqlConnection con = new SqlConnection("Data Source=DILIPC;Database=IDS; Integrated Security = true;Trusted_Connection=true");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Training_Sets";
            con.Open();
            count = (int)cmd.ExecuteScalar();
            con.Close();
            if (count < 10)
            {
                Console.Write("\n ---------------------------------------------------------------\n ");
                Console.Write("\n \t\t\tTraining The IDS :\n ");
                Console.Write("---------------------------------------------------------------\n ");
                Console.Write("\n Total Datasets Entered = " + count+"\n");          
                Console.Write("\n Enter Something Below as a Training Set :\n ");
                DateTime start_time = DateTime.Now;
                string input = Console.ReadLine();
                DateTime end_time = DateTime.Now;
                string logfile = File.ReadAllText(@"F:\Programming Projects\Visual Studio\Visual C#\Key Logger\Key Logger\bin\Debug\log.txt");
                Console.Write("\n ---------------------------------------------------------------");
                TimeSpan t = end_time - start_time;
                float speed = 0F;
                int length = input.Length;
                float time = t.Seconds;
                Console.Write("\n The User Profile of the above entered string is as follows : \n ---------------------------------------------------------------");
                Console.Write("\n Start Time = " + start_time + "\n End Time = " + end_time);
                Console.Write("\n Time Difference is = " + t);
                Console.Write("\n Total Time Span = " + time + " Seconds");
                Console.Write(" \n Total Characters Pressed = " + length + " Characters ");
                speed = (float)(length / time);
                Console.Write("\n The Typing Speed is = " + speed + " Characters/Second");
                int backcount = 0;
                backcount = Regex.Matches(logfile, "Back").Count;
                int length2 = logfile.Length;
                int temp = length2 - (4 * backcount);
                float error_prob = 0F;
                float right_prob = 0F;
                Console.WriteLine("\n Number of Back Spaces Used = " + backcount);
                error_prob = (float)backcount / temp;
                right_prob = 1 - error_prob;
                Console.WriteLine(" Probability of Occurrence of Error = " + error_prob);
                Console.WriteLine(" Probability of Typing Without an Error = " + right_prob);
                Console.Write("\n----------------------------------------------------------------");
                Console.ReadKey();
                //speed,error_prob,right_prob
                cmd.CommandText = "Insert into [Training_Sets] (Typing_Speed,Error_Probability,Right_Probability) values('" + speed + "','" + error_prob + "','" + right_prob + "')";
                SqlDataReader Row_reader;
                con.Open();
                Row_reader = cmd.ExecuteReader();
                con.Close();
                if(count==9)
                {
                    cmd.CommandText = "Select AVG(Typing_Speed) from Training_Sets";
                    con.Open();
                    string avgtp = cmd.ExecuteScalar().ToString();
                    cmd.CommandText = "Select AVG(Error_Probability) from Training_Sets";
                    string avgep = cmd.ExecuteScalar().ToString();
                    cmd.CommandText = "Select AVG(Right_Probability) from Training_Sets";
                    string avgrp = cmd.ExecuteScalar().ToString();
                    cmd.CommandText = "Insert into [Threshold] ( [Avg_Typ_Sp],[Avg_Err_Pr],[Avg_Rg_Pr]) values('" + avgtp + "','" + avgep + "','" + avgrp + "')";
                    Row_reader = cmd.ExecuteReader();
                    con.Close();
                }


            }
            else
            {
                Console.Write("\n Only 10 data sets are allowed to train the IDS");
                Console.ReadKey();
            }
        }

        public static void Check()
        {
            SqlConnection con = new SqlConnection("Data Source=DILIPC;Database=IDS; Integrated Security = true;Trusted_Connection=true");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT TOP 1 [Avg_Typ_Sp]FROM[Threshold]";
            con.Open();
            string sp = cmd.ExecuteScalar().ToString();
            cmd.CommandText = "SELECT TOP 1 [Avg_Err_Pr]FROM[Threshold]";
            string ep = cmd.ExecuteScalar().ToString();
            cmd.CommandText = "SELECT TOP 1 [Avg_Rg_Pr]FROM[Threshold]";
            string rp = cmd.ExecuteScalar().ToString();
            float ty_speed = float.Parse(sp);
            float error_pr = float.Parse(ep);
            float right_pr = float.Parse(rp);
            Console.Write("\n ---------------------------------------------------------------\n ");
            Console.Write("\n \t\t\tChecking The IDS :\n ");
            Console.Write("---------------------------------------------------------------\n ");
            Console.Write("\n Enter Something Below :\n ");
            DateTime start_time = DateTime.Now;
            string input = Console.ReadLine();
            DateTime end_time = DateTime.Now;
            string logfile = File.ReadAllText(@"F:\Programming Projects\Visual Studio\Visual C#\Key Logger\Key Logger\bin\Debug\log.txt");
            Console.Write("\n ---------------------------------------------------------------");
            TimeSpan t = end_time - start_time;
            float speed = 0F;
            int length = input.Length;
            float time = t.Seconds;
            Console.Write("\n The User Profile of the above entered string is as follows : \n ---------------------------------------------------------------");

            speed = (float)(length / time);
            Console.WriteLine("\n The Typing Speed is = " + speed + " Characters/Second");
            int backcount = 0;
            backcount = Regex.Matches(logfile, "Back").Count;
            int length2 = logfile.Length;
            int temp = length2 - (4 * backcount);
            float error_prob = 0F;
            float right_prob = 0F;
         
            error_prob = (float)backcount / temp;
            right_prob = 1 - error_prob;
            Console.WriteLine("\n Probability of Occurrence of Error = " + error_prob);
            Console.WriteLine("\n Probability of Typing Without an Error = " + right_prob);
            Console.Write("\n----------------------------------------------------------------");
            double r1, r2;
            r1 = ty_speed - 3;
            r2 = ty_speed + 3;
            
            int check = 0;
            if (speed >= r1 & speed <= r2)
            {
                check++;
                if (check == 1)
                    Console.ForegroundColor = ConsoleColor.Yellow;
            }
            Console.WriteLine("\n Threshold Speed Range : " + r1 + " -- " + r2);
            Console.ForegroundColor = ConsoleColor.Gray;
            r1 = error_pr - 0.1;
            r2 = error_pr + 0.1;

            if (error_prob >= r1 & error_prob <= r2)
            {
                check++;
                if (check == 2)
                    Console.ForegroundColor = ConsoleColor.Yellow;
            }
            Console.WriteLine("\n Error Probability Confidence Range : " + r1 + " -- " + r2);
            Console.ForegroundColor = ConsoleColor.Gray;
            r1 = right_pr - 0.1;
            r2 = right_pr + 0.1;

            if (right_prob >= 1 & right_prob <= r2)
            {
                check++;
                if (check == 3)
                    Console.ForegroundColor = ConsoleColor.Yellow;
            }
                Console.WriteLine("\n Right Probability Confidence Range : " + r1 + " -- " + r2);
            Console.ForegroundColor = ConsoleColor.Gray;
            if (check == 3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Beep(1000, 800);
                Console.Write("\n----------------------------------------------------------------");
                Console.WriteLine("\n Right User");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Beep(1000, 800);
                Console.Write("\n----------------------------------------------------------------");
                Console.WriteLine("\n Wrong User");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();


        }
    }
}
