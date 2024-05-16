using NAudio.Wave;
using SpeakingChatbot.UserControls;
using System;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace SpeakingChatbot {
    internal class UserDetected {
        private static string[] imagePaths = new string[]
        {
            "..\\..\\..\\assets\\Speak1.png",
            "..\\..\\..\\assets\\Speak2.png",
            "..\\..\\..\\assets\\Speak3.png"
        };
        private static int currentImageIndex = 0;
        private static Timer timer;
        private static Timer idleTimer;

        public static void HandleVoice(ChatUC mainForm, string message, string audioFile, string firstWord, string words) {
            Console.WriteLine(message);

            if (message == "Voice detected!" && firstWord == words) {
                StartCyclingImages(mainForm);
                PlayAudio(audioFile, mainForm);
            } else {
                Image idleImage = Image.FromFile("..\\..\\..\\assets\\Idle1.png");
                mainForm.SetPictureBoxImage(idleImage);
            }
        }

        private static void StartCyclingImages(ChatUC mainForm) {
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += (s, e) => {
                Image currentImage = Image.FromFile(imagePaths[currentImageIndex]);
                mainForm.SetPictureBoxImage(currentImage);

                currentImageIndex = (currentImageIndex + 1) % imagePaths.Length;
            };
            timer.Start();
        }

        private static void PlayAudio(string audioFile, ChatUC mainForm) {
            try {
                using (var waveOut = new WaveOutEvent()) {
                    using (var mp3Reader = new Mp3FileReader(audioFile)) {
                        waveOut.Init(mp3Reader);
                        waveOut.Play();

                        waveOut.PlaybackStopped += (s, e) => {
                            timer.Stop();
                            Image idleImage = Image.FromFile("..\\..\\..\\assets\\Idle1.png");
                            mainForm.SetPictureBoxImage(idleImage);
                        };

                        while (waveOut.PlaybackState == PlaybackState.Playing) {
                            Application.DoEvents();
                        }
                    }
                }
            } catch (Exception) {
                //buggy bywwwww
            }
        }
    }
}


