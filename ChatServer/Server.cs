using ChatServer.Net.IO;
using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection.Metadata;

namespace ChatServer {

    internal class Server {

        // CHANGE SA IPADDRESS NG MAIN LAPTOP NA MAGHOHOST NG SERVERRRR
        // static string address = "192.168.18.77";
        static string address = "127.0.0.1";
        static int port = 8080;

        static TcpListener listener;
        static List<Client> clients;

        // gc maybe?
        // static List channels;

        static void Main(string[] args) {

            clients = new List<Client>();
            listener = new TcpListener(IPAddress.Parse(address), port);

            // this will start the server
            listener.Start();
            Console.WriteLine("Server has started");

            while (true) {
                // accept the connection from the client
                var client = new Client(listener.AcceptTcpClient());
                clients.Add(item: client);

                // broadcast the connection to everyone// new user arrive chuchu
                // online/offline -- connected/disconnected sa server
                BroadcastConnection();
            }

        }

        // public gc
        static void BroadcastConnection() {
            // di ko gets maybe can do in one loop lamg? send curusername to other username


            foreach (var client in clients) {
                foreach (var client1 in clients) {
                    var broadcastPacket = new Net.IO.PacketBuilder();
                    broadcastPacket.WriteOpCode(1);
                    broadcastPacket.WriteMsg(client1.userName);
                    client.clientSocket.Client.Send(broadcastPacket.GetPacketBytes());
                }
            }
        }


        // send to specific person
        public static void SendMsg(string msg, string SenderUID, string ReceiverUID) {
            var msgPacket = new Net.IO.PacketBuilder();
            msgPacket.WriteOpCode(5);
            msgPacket.WriteMsg(SenderUID);
            msgPacket.WriteMsg(msg);

            var receiverUser = clients.Where(x => x.userName == ReceiverUID).FirstOrDefault();
            receiverUser.clientSocket.Client.Send(msgPacket.GetPacketBytes());
        }


        // send to all
        public static void BroadcastMsg(string senderUser, string recevingUser, string msg) {
            foreach(var client in clients) {
                if (client.userName != senderUser) {
                    var msgPacket = new Net.IO.PacketBuilder();
                    msgPacket.WriteOpCode(5);
                    msgPacket.WriteMsg(senderUser);
                    msgPacket.WriteMsg(recevingUser);
                    msgPacket.WriteMsg(msg);


                    Console.WriteLine(senderUser);
                    Console.WriteLine(recevingUser);
                    Console.WriteLine(msg);
                    client.clientSocket.Client.Send(msgPacket.GetPacketBytes());
                }
            }
        }

        public static void BroadcastDisconnect(string userName) {

            var disconnectedUser = clients.Where(x => x.userName == userName).FirstOrDefault();

            clients.Remove(disconnectedUser);

            foreach (var client in clients) {
                var broadcastPacket = new PacketBuilder();
                // opcode for user disconnect is 10
                broadcastPacket.WriteOpCode(10);
                broadcastPacket.WriteMsg(userName);
                client.clientSocket.Client.Send(broadcastPacket.GetPacketBytes());
            }

            BroadcastMsg(userName, "@everyone", $"[{disconnectedUser.userName}] Disconnected");
        }
    }
}
