using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using NAudio.Wave;
using NAudio.Lame;
using System.Speech.Synthesis;
using System.Speech.AudioFormat;
using Timer = System.Windows.Forms.Timer;
using SpeakingChatbot;

internal static class Program {
    [STAThread]
    static void Main() {
        ApplicationConfiguration.Initialize();
        Chavatar mainForm = new Chavatar();
        AudioDetector audioDetector = new AudioDetector();

        Application.Run(mainForm);
    }
}