using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NAudio.Wave;
using System.Threading;
using Terminal.Gui;

namespace WindowsFormsApp1
{
    class MusicPlayer
    {
        public WaveOutEvent outputDevice;
        public AudioFileReader audioFile;
        public string lastFileOpened;
        public OpenDialog d;

        public void DisposeWave()
        {
            if (outputDevice != null)
            {
                if (outputDevice.PlaybackState == PlaybackState.Playing) outputDevice.Stop();
                outputDevice.Dispose();
                outputDevice = null;
            }
            if (audioFile != null)
            {
                audioFile.Dispose();
                audioFile = null;
            }
        }


        public void OpenFile()
        {
            d = new OpenDialog("Open", "Open an audio file") { AllowsMultipleSelection = false };
            d.AllowedFileTypes = new string[] { ".mp3", ".wav", ".flac" };
            if (lastFileOpened != null)
            {
                d.DirectoryPath = lastFileOpened;
            }
            Application.Run(d);

            if (!d.Canceled)
            {
                DisposeWave();

                this.lastFileOpened = d.FilePath.ToString();
                this.audioFile = new AudioFileReader(d.FilePath.ToString());
                this.outputDevice = new WaveOutEvent();
                this.outputDevice.Init(audioFile);
                this.outputDevice.Play();
            }
        }

        public void PlayFromPlaylist()
        {

        }

        public void Play()
        {
            if (this.audioFile != null)
            {
                try
                {
                    this.outputDevice.Play();
                }
                catch (System.Runtime.InteropServices.COMException)
                {
                }
            }
        }
        public void Pause()
        {
            try
            {
                this.outputDevice?.Pause();
            }
            catch (System.NullReferenceException)
            {
            }
        }

        public void Stop()
        {
            try
            {
                this.outputDevice.Stop();
            }
            catch (System.NullReferenceException)
            {
            }
        }

        public void IncreaseVolume()
        {
            if (this.outputDevice != null)
            {
                if (this.outputDevice.Volume > 0.9f)
                {
                    this.outputDevice.Volume = 1.0f;
                    return;
                }

                this.outputDevice.Volume += 0.1f;
            }
        }

        public void DecreaseVolume()
        {
            if (this.outputDevice != null)
            {
                if (this.outputDevice.Volume < 0.1f)
                {
                    this.outputDevice.Volume = 0.0f;
                    return;
                }
                this.outputDevice.Volume -= 0.1f;
            }
        }

        public System.TimeSpan CurrentTrackTime()
        {
            TimeSpan initialTime = new TimeSpan(0);
            if (this.outputDevice != null && this.outputDevice.PlaybackState != PlaybackState.Paused)
            {
                return this.audioFile.CurrentTime;
            }
            else
            {
                return initialTime;
            }
        }

        public System.TimeSpan CurrentTrackLength()
        {
            if (this.audioFile != null)
            {
                return this.audioFile.TotalTime;
            }
            else
            {
                return new TimeSpan(0);
            }
        }

        public void fastForward()
        {
            if (this.audioFile != null && this.audioFile.CurrentTime <= this.audioFile.TotalTime)
            {
                this.audioFile.CurrentTime = this.audioFile.CurrentTime.Add(TimeSpan.FromSeconds(3));
            }
        }

        public void Rewind()
        {
            if (this.audioFile != null && this.audioFile.CurrentTime >= TimeSpan.FromSeconds(3))
            {
                this.audioFile.CurrentTime = this.audioFile.CurrentTime.Subtract(TimeSpan.FromSeconds(3));
            }
        }

        public void fasterFastForward()
        {
            if (this.audioFile != null && this.audioFile.CurrentTime <= this.audioFile.TotalTime)
            {
                this.audioFile.CurrentTime = this.audioFile.CurrentTime.Add(TimeSpan.FromSeconds(10));
            }
        }

        public void fasterRewind()
        {
            if (this.audioFile != null && this.audioFile.CurrentTime >= TimeSpan.FromSeconds(10))
            {
                this.audioFile.CurrentTime = this.audioFile.CurrentTime.Subtract(TimeSpan.FromSeconds(10));
            }
        }
    }
}
