using System;
using System.Net.NetworkInformation;
using System.Threading;
using System.Net;
namespace brapper
{


    class Program
    {
        public static IPAddress GetDefaultGateway()
        {
            NetworkInterface Gateway=null;
            foreach (var Interface in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (Interface.OperationalStatus == OperationalStatus.Up && Interface.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                {
                    Gateway = Interface;
                    break;
                }
            }
            try
            {
                return Gateway.GetIPProperties().GatewayAddresses[0].Address;
            }
            catch
            {
                return new IPAddress(16777343); //localhost
            }
        }
        public static void PingHost()
        {
            IPAddress Host = GetDefaultGateway();
            int packetSize = 200; 
            int Timeout = 1; 
            byte[] Packet = new byte[packetSize]; 
            ////example of packet initialization
          //  for (int i = 6; i < packetSize; i+=16)
         //   {
         //       packet[i] = 0x48;//H
          //      packet[i+1] = 0x45;//E
         //       packet[i+2] = 0x4c;//L
         //       packet[i+3] = 0x4c;//L
         //       packet[i+4] = 0x4f;//O
         //   }

            Ping Ping = new Ping();
            while(true)
                Ping.Send(Host, Timeout, Packet);
            
        }
        static void Main(string[] args)
        {
            Thread Pinger;
            Console.WriteLine("on how many threads should i run pinger?");
            string k=Console.ReadLine();
            for (int i = 0; i<Convert.ToInt32(k); i++)
            {
                Pinger= new Thread(new ThreadStart(PingHost));
                Pinger.Start();
            }

        }
    }





}
