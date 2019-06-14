using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Management;
using System.Windows;
using System.Windows.Data;

namespace ApplicationsListing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<ApplicationAll> programs { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            programs = new List<ApplicationAll>();

            //string uninstallKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            //RegistryKey rk;

            //using (rk = Registry.CurrentUser.OpenSubKey(uninstallKey))
            //{
            //    foreach (string skName in rk.GetSubKeyNames())
            //    {
            //        using (RegistryKey sk = rk.OpenSubKey(skName))
            //        {
            //            try
            //            {

            //                var displayName = sk.GetValue("DisplayName");
            //                var Size = sk.GetValue("EstimatedSize");

            //                programs.Add(new ApplicationAll { name = displayName.ToString(), size = Convert.ToInt32(Size) });

            //            }
            //            catch (Exception ex)
            //            { }
            //        }
            //    }
            //}


            ////using (rk = Registry.LocalMachine.OpenSubKey(uninstallKey))
            ////{
            ////    foreach (string skName in rk.GetSubKeyNames())
            ////    {
            ////        using (RegistryKey sk = rk.OpenSubKey(skName))
            ////        {
            ////            try
            ////            {

            ////                var displayName = sk.GetValue("DisplayName");
            ////                var Size = sk.GetValue("EstimatedSize");

            ////                programs.Add(new ApplicationAll { name = displayName.ToString(), size = Convert.ToInt32(Size) });

            ////            }
            ////            catch (Exception ex)
            ////            { }
            ////        }
            ////    }
            ////}

            //using (rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall"))
            //{
            //    foreach (string skName in rk.GetSubKeyNames())
            //    {
            //        using (RegistryKey sk = rk.OpenSubKey(skName))
            //        {
            //            try
            //            {

            //                var displayName = sk.GetValue("DisplayName");
            //                var Size = sk.GetValue("EstimatedSize");

            //                programs.Add(new ApplicationAll { name = displayName.ToString(), size = Convert.ToInt32(Size) });

            //            }
            //            catch (Exception ex)
            //            { }
            //        }
            //    }
            //}

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Product");
            foreach (ManagementObject mgmtObject in searcher.Get())
            {
                //Console.WriteLine(mgmtObject["Name"]);

                programs.Add(new ApplicationAll { name = mgmtObject["Name"].ToString(), size = 0});
            }

            try
            {
                CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(programs);
                view.SortDescriptions.Add(new SortDescription("name", ListSortDirection.Ascending));
            }
            catch (Exception) { }


            Datagrid_Applications.ItemsSource = programs;
            MessageBox.Show(programs.Count.ToString());
        }
    }

    public class ApplicationAll
    {
        public string name { get; set; }

        public int size { get; set; }
    }
}
