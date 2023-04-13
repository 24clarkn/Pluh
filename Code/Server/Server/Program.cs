using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Server
{
    class Program
    {
        public static string HostIP = "127.0.0.1";
        public static void Main(string[] args)
        {
            ServerSck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ServerSck.Bind(new IPEndPoint(IPAddress.Parse(HostIP), 8080));
            Console.WriteLine($"[SERVER] Server is connected at {HostIP}!");
            ServerSck.Listen(100);

            while (true)
            {
                Socket Accepted = ServerSck.Accept();
                Buffer = new byte[Accepted.SendBufferSize];
                int BytesRead = Accepted.Receive(Buffer);
                byte[] Formatted = new byte[BytesRead];
                for (int i = 0; i < BytesRead; i++)
                    Formatted[i] = Buffer[i];

                string StringData = Encoding.ASCII.GetString(Formatted);
                Console.WriteLine($"[SERVER - PACKET FROM CLIENT] {StringData}");

                Accepted.Close();
            }

            /*Thread ServerThread = new Thread(ServerStartHost);
            ServerThread.Start();*/

            //ClientSendData();
        }

        static byte[] Buffer { get; set; }
        static Socket ServerSck;
        public static void ServerStartHost()
        {
            ServerSck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ServerSck.Bind(new IPEndPoint(IPAddress.Parse(HostIP), 80));
            Console.WriteLine($"[SERVER] Server is connected at {HostIP}!");
            ServerSck.Listen(100);

            Socket Accepted = ServerSck.Accept();
            Buffer = new byte[Accepted.SendBufferSize];
            int BytesRead = Accepted.Receive(Buffer);
            byte[] Formatted = new byte[BytesRead];
            for (int i = 0; i < BytesRead; i++)
            {
                Formatted[i] = Buffer[i];
            }

            string StringData = Encoding.ASCII.GetString(Formatted);
            Console.WriteLine($"[SERVER] {StringData}");
            Console.ReadKey();
            ServerSck.Close();
            Accepted.Close();
        }

        static Socket ClientSck;
        public static void ClientSendData()
        {
            ClientSck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint LocalEndPoint = new IPEndPoint(IPAddress.Parse(HostIP), 80);
            try { ClientSck.Connect(LocalEndPoint); }
            catch { Console.WriteLine($"Could not connect!"); return; }

            while (true)
            {
                Console.Write($"[CLIENT] Enter Text: ");
                string Text = Console.ReadLine();

                if (Text.ToLower() == "close")
                    break;

                byte[] Data = Encoding.ASCII.GetBytes(Text);
                ClientSck.Send(Data);
                Console.WriteLine($"[CLIENT] Data Sent!");
                Console.ReadKey();
            }

            ClientSck.Close();
        }
    }
}
