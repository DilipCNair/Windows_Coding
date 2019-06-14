using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Log_Reader
{
    class Program
    {
        static void Main(string[] args)
        {


            string logfile = File.ReadAllText(@"F:\Programming Projects\Visual Studio\Visual C#\Key Logger\Key Logger\bin\Debug\log.txt");
            int space_count = 0, lctrl_count = 0, rctrl_count = 0, lshift_count = 0, rshift_count = 0, return_count = 0, tab_count = 0, left_count = 0, up_count = 0, right_count = 0, down_count = 0;
            int back_count = 0, capital_count = 0, f1c = 0, f2c = 0, f3c = 0, f4c = 0, f5c = 0, f6c = 0, f7c = 0, f8c = 0, f9c = 0, f10c = 0, f11c = 0, f12c = 0, lwinc = 0, delc = 0, homec = 0, endc = 0, pageupc = 0, pagedownc = 0, numlockc = 0;
            string searchWithinThis = logfile;
            string searchForSpace = "Space";
            string searchForLControlKey = "LControlKey"; string searchForRControlKey = "RControlKey";
            string searchForRShiftKey = "RShiftKey"; string searchForLShiftKey = "LShiftKey";
            string searchForReturn = "Return";
            string searchForTab = "Tab";
            string searchForLeft = "Left"; string searchForUp = "Up"; string searchForRight = "Right"; string searchForDown = "Down";
            string searchForBack = "Back";
            string searchForCapital = "Capital";
            string searchForF1 = "F1"; string searchForF2 = "F2"; string searchForF3 = "F3"; string searchForF4 = "F4"; string searchForF5 = "F5"; string searchForF6 = "F6"; string searchForF7 = "F7"; string searchForF8 = "F8"; string searchForF9 = "F9"; string searchForF10 = "F10"; string searchForF11 = "F11"; string searchForF12 = "F12";
            string searchForLwin = "LWin";
            string searchForDelete = "Delete";
            string searchForHome = "Home";
            string searchForEnd = "End";
            string searchForPageUp = "PageUp";
            string searchForPageDown = "Next";
            string searchForNumLock = "NumLock";



            space_count = Regex.Matches(logfile, searchForSpace).Count;
            lshift_count = Regex.Matches(logfile, searchForLShiftKey).Count;
            rshift_count = Regex.Matches(logfile, searchForRShiftKey).Count;
            lctrl_count = Regex.Matches(logfile, searchForLControlKey).Count;
            rctrl_count = Regex.Matches(logfile, searchForRControlKey).Count;
            tab_count = Regex.Matches(logfile, searchForTab).Count;
            capital_count = Regex.Matches(logfile, searchForCapital).Count;
            return_count = Regex.Matches(logfile, searchForReturn).Count;
            numlockc = Regex.Matches(logfile, searchForNumLock).Count;
            down_count = Regex.Matches(logfile, searchForDown).Count;
            left_count = Regex.Matches(logfile, searchForLeft).Count;
            right_count = Regex.Matches(logfile, searchForRight).Count;
            f1c = Regex.Matches(logfile, searchForF1).Count;
            f2c = Regex.Matches(logfile, searchForF2).Count;
            f3c = Regex.Matches(logfile, searchForF3).Count;
            f4c = Regex.Matches(logfile, searchForF4).Count;
            f5c = Regex.Matches(logfile, searchForF5).Count;
            f6c = Regex.Matches(logfile, searchForF6).Count;
            f7c = Regex.Matches(logfile, searchForF7).Count;
            f8c = Regex.Matches(logfile, searchForF8).Count;
            f9c = Regex.Matches(logfile, searchForF9).Count;
            f10c = Regex.Matches(logfile, searchForF10).Count;
            f11c = Regex.Matches(logfile, searchForF11).Count;
            f12c = Regex.Matches(logfile, searchForF12).Count;
            delc = Regex.Matches(logfile, searchForDelete).Count;
            homec = Regex.Matches(logfile, searchForHome).Count;
            endc = Regex.Matches(logfile, searchForEnd).Count;
            pageupc = Regex.Matches(logfile, searchForPageUp).Count;
            pagedownc = Regex.Matches(logfile, searchForPageDown).Count;
            back_count = Regex.Matches(logfile, searchForBack).Count;
            lwinc = Regex.Matches(logfile, searchForLwin).Count;
            up_count = Regex.Matches(logfile, searchForUp).Count - pageupc;



            Console.Write("\n ---------------------------------------------------------------\n ");
            Console.WriteLine(" Displaying Log File : \n\n " + logfile);
            Console.Write("\n ---------------------------------------------------------------\n ");
            Console.WriteLine(" Control Keys Pressed Are : \n");
            Console.WriteLine(" Space = " + space_count + "\t\t Page Down = " + pagedownc);
            Console.WriteLine(" Right Shift = " + rshift_count + "\t F1 = " + f1c);
            Console.WriteLine(" Left Shift = " + lshift_count + "\t\t F2 = " + f2c);
            Console.WriteLine(" Right Control = " + rctrl_count + "\t F3 = " + f3c);
            Console.WriteLine(" Left Control = " + lctrl_count + "\t F4 = " + f4c);
            Console.WriteLine(" Enter = " + return_count + "\t\t F5 = " + f5c);
            Console.WriteLine(" Back Space = " + back_count + "\t\t F6 = " + f6c);
            Console.WriteLine(" Caps lock = " + capital_count + "\t\t F7 = " + f7c);
            Console.WriteLine(" Num lock= " + numlockc + "\t\t F8 = " + f8c);
            Console.WriteLine(" Tab = " + tab_count + "\t\t F9 = " + f9c);
            Console.WriteLine(" Windows Key = " + lwinc + "\t F10 = " + f10c);
            Console.WriteLine(" Delete = " + delc + "\t\t F11 = " + f11c);
            Console.WriteLine(" Home = " + homec + "\t\t F12 = " + f12c);
            Console.WriteLine(" End = " + endc + "\t\t Left Arrow = " + left_count);
            Console.WriteLine(" Page Up = " + pageupc + "\t\t Right Arrow = " + right_count);
            Console.WriteLine(" Up Arrow = " + up_count + "\t\t Down Arrow = " + down_count);


            Console.ReadKey();

        }
    }
}
