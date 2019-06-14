using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacketDotNet;
using SharpPcap;

namespace Packet_Capture
{
    class Program
    {
        static void Main(string[] args)
        {
            CaptureDeviceList devices = CaptureDeviceList.Instance;
            foreach (ICaptureDevice device in devices)
            {
                String Ethernet = @"rpcap://\Device\NPF_{1B8EE98D-29DD-472E-BD4C-EA1FD2C5AFB2}";
                string WiFi = @"rpcap://\Device\NPF_{84D36356-D143-4B7E-B0EB-B1EE67FEA65E}";
                ////Console.WriteLine(device.Name.ToString());
                ////Console.WriteLine(device.ToString());
                ////if (string.Equals(device.Name.ToString(), @"rpcap://\Device\NPF_{1B8EE98D-29DD-472E-BD4C-EA1FD2C5AFB2}")) 
                ////    Console.WriteLine(device.ToString());
                ////else
                ////    Console.WriteLine("Not found");
                //if (string.Equals(device.Name.ToString(), WiFi))
                //    Console.WriteLine(device.ToString());
                //else
                //    Console.WriteLine("Not found");
            }
            Console.ReadKey();
        }
    }
}
