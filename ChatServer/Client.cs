using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;
using System.Diagnostics;

using ChatServer.Bot;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ChatServer {
    class Client {

        private string msgFromGemini;
        private string msgToGemini;
        public string userName { get; set; }
        public TcpClient clientSocket { get; set; }

        Net.IO.PacketReader packetReader;

        public Client(TcpClient client) {
            clientSocket = client;

            packetReader = new Net.IO.PacketReader(clientSocket.GetStream());

            var opCode = packetReader.ReadByte();
            userName = packetReader.ReadMsg();

            Console.WriteLine($"[{DateTime.Now}]: {userName} has connected");

            Task.Run(() => Process());
        }

        async void Process() {
            while(true) {
                try {
                    var opCode = packetReader.ReadByte();

                    switch(opCode) {
                        case 5:
                            var senderUser = packetReader.ReadMsg();
                            var receivingUser = packetReader.ReadMsg();
                            var msg = packetReader.ReadMsg();

                            Console.WriteLine($"[{DateTime.Now}]: message received: {msg} from {senderUser} to {receivingUser}");

                            Server.BroadcastMsg(senderUser, receivingUser, msg);
                            
                            if(senderUser == receivingUser) {
                                msgToGemini = msg;
                            } else {
                                // dito icall nalang si gemini bot
                                msgToGemini = checkMsgInput(msg);
                            }

                            Console.WriteLine("msg to gemini {0}", msgToGemini);

                           
                            if (!string.IsNullOrWhiteSpace(msgToGemini)) {
                                msgFromGemini = await GeminiAPI.SendRequestAndGetResponse(msgToGemini);
                                Console.WriteLine(msgFromGemini);
                                Server.BroadcastMsg("@dahlia", receivingUser, msgFromGemini);
                            }

                            break;
                        default:
                            break;

                    }
                } catch(Exception) {
                    Console.WriteLine($"[{userName}]: Disconnected");
                    Server.BroadcastDisconnect(userName);
                    clientSocket.Close();
                    break;
                }
            }
        }

        private string checkMsgInput(string msg) {
            string[] msgFromUser = new string[2];
            string msgToGemini = "";

            msgFromUser = msg.Split(" ", 2, System.StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("aaaaaaaaa {0}", msgFromUser[0]);

            if (msgFromUser[0] == "@dahlia") {
                Console.WriteLine("calling waifuuu");

                // if (calledWaifu[0] == "@waifu")
                try {
                    // question
                    Console.WriteLine(msgFromUser[1]);

                    msgToGemini = msgFromUser[1];
                } catch (Exception ex) {
                    // call waifu lang no msg
                    Console.WriteLine("No question");

                    string[] wakeWaifu = { "hi", "hello", "hey", "you there? " };
                    Random random = new Random();
                    int randomIndex = random.Next(0, wakeWaifu.Length);
                    Console.WriteLine(wakeWaifu[randomIndex]);

                    msgToGemini = wakeWaifu[randomIndex];
                }
            }

            return msgToGemini;
        }


    }
}
