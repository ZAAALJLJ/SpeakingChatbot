using System;
using NAudio.Wave;

public class AudioDetector : IDisposable {
    private WaveOutEvent waveOut;
    private AudioFileReader audioFile;

    public event EventHandler<string> SoundDetected;

    public void DetectAudio(string audioFilePath) {
        try {
            waveOut = new WaveOutEvent();
            audioFile = new AudioFileReader(audioFilePath);
            waveOut.Init(audioFile);

            OnSoundDetected("Voice detected!");

            waveOut.PlaybackStopped += WaveOut_PlaybackStopped;
            waveOut.Play();
        } catch (Exception ex) {
            Console.WriteLine($"Error detecting audio: {ex.Message}");
        }
    }

    private void WaveOut_PlaybackStopped(object sender, StoppedEventArgs e) {
        OnSoundDetected("Oh no!");
        // Dispose();
    }

    protected virtual void OnSoundDetected(string message) {
        SoundDetected?.Invoke(this, message);
    }

    public void Dispose() {
        if (waveOut != null) {
            waveOut.Dispose();
            waveOut = null;
        }
        if (audioFile != null) {
            audioFile.Dispose();
            audioFile = null;
        }
    }
}

