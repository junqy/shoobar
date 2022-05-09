using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace WindowsFormsApp1
{
    public partial class Shoobar : Form
    {
        MusicPlayer player = new MusicPlayer();
        public Shoobar()
        {
            InitializeComponent();
            volume_bar.Value = 2;
        }

        string[] paths, files;

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.DisposeWave();


            player.lastFileOpened = paths[track_list.SelectedIndex].ToString();
            player.audioFile = new AudioFileReader(paths[track_list.SelectedIndex].ToString());
            player.outputDevice = new WaveOutEvent();
            player.outputDevice.Init(player.audioFile);
            player.outputDevice.Play();
            if (Path.GetFileName(paths[track_list.SelectedIndex]).Length > 30)
            {
                song_lbl.Text = (Path.GetFileName(paths[track_list.SelectedIndex]).Substring(0,30) + "...");
            }
            else
            {
                song_lbl.Text = Path.GetFileName(paths[track_list.SelectedIndex]);
            }
            
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            if(player.outputDevice != null)
            {
                player.Stop();
                player.audioFile.CurrentTime = new TimeSpan(0);
            }
           
        }

        private void pause_btn_Click(object sender, EventArgs e)
        {
            player.Pause();
        }

        private void play_btn_Click(object sender, EventArgs e)
        {
            player.Play();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if(track_list.Items.Count > 0)
            {
                if(track_list.SelectedIndex < track_list.Items.Count - 1)
                {
                    track_list.SelectedIndex = track_list.SelectedIndex + 1;
                }
                else
                {
                    track_list.SelectedIndex = 0;
                }
            }

        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            if(track_list.Items.Count > 0)
            {
                if(track_list.SelectedIndex > 0)
                {
                    track_list.SelectedIndex = track_list.SelectedIndex - 1;
                }
                else
                {
                    track_list.SelectedIndex = track_list.Items.Count - 1;
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(player.outputDevice != null && player.outputDevice.PlaybackState != PlaybackState.Paused)
            {
                music_prog_bar.Maximum = Int32.Parse(player.CurrentTrackLength().TotalMilliseconds.ToString());
                music_prog_bar.Value = Int32.Parse(player.CurrentTrackTime().TotalMilliseconds.ToString());
                currlength_lbl.Text = player.CurrentTrackTime().ToString(@"mm\:ss");
                tracklength_lbl.Text = player.CurrentTrackLength().ToString(@"mm\:ss");
                if(player.CurrentTrackTime() == player.CurrentTrackLength() && track_list.SelectedIndex < track_list.Items.Count - 1)
                {
                    track_list.SelectedIndex = track_list.SelectedIndex + 1;
                }
                else if(player.CurrentTrackTime() == player.CurrentTrackLength() && track_list.SelectedIndex == track_list.Items.Count - 1)
                {
                    track_list.SelectedIndex = 0;
                }
            }

        }

        private void volume_bar_Scroll(object sender, EventArgs e)
        {
            if(player.outputDevice != null)
            {
                float vol = volume_bar.Value;
                player.outputDevice.Volume = vol/10;
            }
            
        }

        private void music_prog_bar_MouseDown(object sender, MouseEventArgs e)
        {
            if(player.outputDevice != null)
            {
                var temp = player.CurrentTrackLength().TotalMilliseconds * e.X / music_prog_bar.Width;
                player.audioFile.CurrentTime = new TimeSpan(0);
                player.audioFile.CurrentTime = player.audioFile.CurrentTime.Add(TimeSpan.FromMilliseconds(temp));
            }
            
        }

        private void forward_btn_Click(object sender, EventArgs e)
        {
            player.fasterFastForward();
        }

        private void rewind_btn_Click(object sender, EventArgs e)
        {
            player.fasterRewind();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            string path = "playlist.txt";
            if(paths != null)
            {
                File.WriteAllLines(path, paths);
            }          
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            if (File.Exists("playlist.txt"))
            {
                track_list.Items.Clear();
                files = File.ReadAllLines("playlist.txt");
                paths = File.ReadAllLines("playlist.txt");
                for(int x = 0; x<files.Length; x++)
                {
                    track_list.Items.Add(Path.GetFileName(files[x]));
                }
            }
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "MP3, WAV, FLAC|*.wav;*.flac;*.mp3";
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                track_list.Items.Clear();
                files = ofd.FileNames;
                paths = ofd.FileNames;
                for(int x = 0; x<files.Length; x++)
                {
                    track_list.Items.Add(Path.GetFileName(files[x]));
                }
            }
        }
    }
}
