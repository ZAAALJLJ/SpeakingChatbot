﻿using NAudio.Wave;
using SpeakingChatbot.UserControls;
using System;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace SpeakingChatbot
{
    internal class VoiceDetected
    {
        private static string[] imagePaths = new string[]
        {
            "..\\..\\..\\assets\\Speak1.png",
            "..\\..\\..\\assets\\Speak2.png",
            "..\\..\\..\\assets\\Speak3.png"
        };
        private static int currentImageIndex = 0;
        private static Timer timer;
        private static Timer idleTimer;

        public static void HandleVoice(ChatbotUC mainForm, string message, string audioFile, string firstWord, string words)
        {
            Console.WriteLine(message);

            if (message == "Voice detected!" && firstWord == words)
            {
                StopIdleCycle(); 
                StartCyclingImages(mainForm);
                PlayAudio(audioFile, mainForm);
            }
            else
            {
            }
        }

        private static void StartCyclingImages(ChatbotUC mainForm)
        {
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += (s, e) =>
            {
                Image currentImage = Image.FromFile(imagePaths[currentImageIndex]);
                mainForm.SetPictureBoxImage(currentImage);

                currentImageIndex = (currentImageIndex + 1) % imagePaths.Length;
            };
            timer.Start();
        }

        private static void PlayAudio(string audioFile, ChatbotUC mainForm)
        {
            try
            {
                using (var waveOut = new WaveOutEvent())
                {
                    using (var mp3Reader = new Mp3FileReader(audioFile))
                    {
                        waveOut.Init(mp3Reader);
                        waveOut.Play();

                        waveOut.PlaybackStopped += (s, e) =>
                        {
                            timer.Stop();
                            Image idleImage = Image.FromFile("..\\..\\..\\assets\\Idle1.png");
                            mainForm.SetPictureBoxImage(idleImage);
                        };

                        while (waveOut.PlaybackState == PlaybackState.Playing)
                        {
                            Application.DoEvents();
                        }
                    }
                }
            }
            catch (Exception)
            {
                //buggy bywwwww
            }
        }

/*        private static void CycleIdleImages(ChatbotUC mainForm)
        {
            string[] idleImagePaths = new string[]
            {
                "..\\..\\..\\assets\\Idle1.png",
                "..\\..\\..\\assets\\Idle2.png"
            };

            int idleImageIndex = 0;

            idleTimer = new Timer();
            idleTimer.Interval = 1000;
            idleTimer.Tick += (s, e) =>
            {
                Image idleImage = Image.FromFile(idleImagePaths[idleImageIndex]);
                mainForm.SetPictureBoxImage(idleImage);

                idleImageIndex = (idleImageIndex + 1) % idleImagePaths.Length;
            };
            idleTimer.Start();
        }
*/
        private static void StopIdleCycle()
        {
            if (idleTimer != null)
            {
                idleTimer.Stop();
            }
        }
    }
}

