using SpeakingChatbot.socket.IO;
using SpeakingChatbot.UserControls;
using SpeakingChatbot.UserControls.SubUC;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SpeakingChatbot.socket {
    internal class socketControl {

        TcpClient client;

        public socketControl() {
            client = new TcpClient();
        }

        public IO.PacketReader packetReader;

        // login
        public event EventHandler<string> connectedEvent;
        // send msg
        public event EventHandler<string[]> msgChatBotReceivedEvent;
        // send msg
        public event EventHandler<string[]> msgChatUsersReceivedEvent;
        // logout
        public event EventHandler<string> userDisconnectEvent;


        public event EventHandler Trial;

        private void ReadPackets() {
            Task.Run(() => {
                while (true) {
                    var opCode = packetReader.ReadByte();
                    switch (opCode) {
                        case 1:
                            var userConnected = packetReader.ReadMsg();
                            connectedEvent?.Invoke(this, userConnected);
                            break;
                        case 5:
                            var senderUser = packetReader.ReadMsg();
                            var receivingUser = packetReader.ReadMsg();
                            var msg = packetReader.ReadMsg();

                            string[] infoArr= { senderUser, receivingUser, msg};

                            if (receivingUser != "@everyone") {
                                Debug.WriteLine("me and dahlia only");
                                msgChatBotReceivedEvent?.Invoke(this, infoArr);
                            } else {
                                Debug.WriteLine("groupchat / 1v1");
                                msgChatUsersReceivedEvent.Invoke(this, infoArr);
                            }
                            break;
                        case 10:
                            var userDisconnected = packetReader.ReadMsg();
                            userDisconnectEvent?.Invoke(this, userDisconnected);
                            break;
                        default:
                            Console.WriteLine("ahh yes..");
                            break;
                    }
                }
            });
        }

        public void ConnectToServer(string username) {

            // store sa env
            // CHANGE SA IPADDRESS NG MAIN LAPTOP NA MAGHOHOST NG SERVERRRR
            // string address = "192.168.18.77";
            string address = "127.0.0.1";
            int port = 8080;

            if (!client.Connected) {
                try {
                    client.Connect(address, port);

                    packetReader = new IO.PacketReader(client.GetStream());

                    if (!string.IsNullOrEmpty(username)) {
                        var connectPacket = new IO.PacketBuilder();
                        connectPacket.WriteOpCode(0);
                        connectPacket.WriteMsg(username);
                        // send packet sa server
                        client.Client.Send(connectPacket.GetPacketBytes());
                    }

                    ReadPackets();

                } catch (Exception err) {
                    Debug.WriteLine($"Error Connecting client: {err}");
                }

            }
        }

        public void SendMsgToServer(string msg, string senderUser, string recevingUser) {
            var msgPacket = new IO.PacketBuilder();
            // 5 the opcode to send a msg
            msgPacket.WriteOpCode(5);
            msgPacket.WriteMsg(senderUser);
            msgPacket.WriteMsg(recevingUser);
            msgPacket.WriteMsg(msg);
            client.Client.Send(msgPacket.GetPacketBytes());
        }

    }
}
