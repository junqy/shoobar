using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Gui;

namespace WindowsFormsApp1
{
    class Menu
    {
        MusicPlayer player = new MusicPlayer();
        Label trackLength;
        Label trackCurrent;
        Label trackName;
        private object mainLoopTimeout = null;
        private uint mainLooopTimeoutTick = 1000;

        public void Start()
        {
            Application.Init();
            var top = Application.Top;

            var win = new Window("SHOOBAR")
            {
                X = 0,
                Y = 1,
                Width = Dim.Fill(),
                Height = Dim.Fill(),
                ColorScheme = Colors.TopLevel
            };

            var currentlyPlaying = new FrameView("CURRENTLY PLAYING")
            {
                X = 70,
                Y = 18,
                Width = Dim.Fill(),
                Height = 4,
                ColorScheme = Colors.TopLevel
            };

            var upperMenu = new MenuBar(new MenuBarItem[]
            {
                new MenuBarItem("_Plik", new MenuItem[]
                {
                    new MenuItem("_Otwórz", "Otwórz plik muzyczny", () => OpenFile()),
                    new MenuItem("_Wyjdź", "Wyłącz Shoobar'a", () => Application.RequestStop()),
                }),
                new MenuBarItem("_Pomoc", new MenuItem[]
                {
                    new MenuItem("_Informacje", string.Empty, () =>
                    {
                        MessageBox.Query("Shoobar", "\nPLACEHOLDER na jakies informacje blablabala \n blablablablalbalbalblablalbalbalbla \n", "Wyjdź");
                    }),
                }),
            });
            upperMenu.ColorScheme = Colors.TopLevel;

            var playOptions = new FrameView("PLAYBACK")
            {
                X = 0,
                Y = 22,
                Width = Dim.Fill(),
                Height = 5,
                CanFocus = true,
                ColorScheme = Colors.TopLevel
            };

            var playBtn = new Button(50, 0, "PLAY ");
            playBtn.Clicked += () =>
            {
                if (player.lastFileOpened != null && player.outputDevice != null)
                {
                    try
                    {
                        player.Play();
                        CurrentTrackTime();
                    }
                    catch (System.NullReferenceException)
                    {
                    }
                }
                else
                {
                    OpenFile();
                }
            };

            var pauseBtn = new Button(50, 2, "PAUSE");
            pauseBtn.Clicked += () =>
            {
                player.Pause();
            };

            var incVolBtn = new Button(100, 0, "VOLUME++");
            incVolBtn.Clicked += () =>
            {
                player.IncreaseVolume();
            };

            var decVolBtn = new Button(100, 2, "VOLUME--");
            decVolBtn.Clicked += () =>
            {
                player.DecreaseVolume();
            };

            var fastForwardBtn = new Button(60, 0, "FORWARD <+3s>");
            fastForwardBtn.Clicked += () =>
            {
                player.fastForward();
            };

            var rewindBtn = new Button(33, 0, "REWIND <-3s>");
            rewindBtn.Clicked += () =>
            {
                player.Rewind();
            };

            var fasterFastForwardBtn = new Button(60, 2, "FORWARD <+10s>");
            fasterFastForwardBtn.Clicked += () =>
            {
                player.fasterFastForward();
            };

            var fasterRewindBtn = new Button(32, 2, "REWIND <-10s>");
            fasterRewindBtn.Clicked += () =>
            {
                player.fasterRewind();
            };

            void CurrentTrackLength()
            {
                trackLength = new Label(player.CurrentTrackLength().ToString(@"mm\:ss"))
                {
                    X = 8,
                    Y = 1,
                    ColorScheme = Colors.TopLevel
                };

                currentlyPlaying.Add(trackLength);
            }

            void CurrentTrackTimeLabel(string timePlayed)
            {
                trackCurrent = new Label($"{timePlayed} / ")
                {
                    X = 0,
                    Y = 1,
                    ColorScheme = Colors.TopLevel
                };

                currentlyPlaying.Add(trackCurrent);
            }

            void CurrentTrackName(string name)
            {
                trackName = new Label(name)
                {
                    X = 0,
                    Y = 0,
                    Width = Dim.Fill()
                };
                currentlyPlaying.Add(trackName);
            }

            void CurrentTrackTime()
            {
                double counter = Convert.ToInt32(player.CurrentTrackLength().TotalSeconds);
                this.mainLoopTimeout = Application.MainLoop.AddTimeout(TimeSpan.FromMilliseconds(this.mainLooopTimeoutTick), (loop) =>
                {
                    while (counter != 0 && player.outputDevice.PlaybackState != NAudio.Wave.PlaybackState.Paused)
                    {
                        CurrentTrackTimeLabel(player.CurrentTrackTime().ToString(@"mm\:ss"));
                        counter--;
                        return true;
                    }
                    return false;
                });
            }

            void OpenFile()
            {
                player.OpenFile();
                if (!player.d.Canceled)
                {
                    CurrentTrackLength();
                    CurrentTrackTime();
                    CurrentTrackName(player.audioFile.FileName.Substring(0, 40) + "...");
                }

            }


            win.Add(playOptions, currentlyPlaying);
            playOptions.Add(playBtn, pauseBtn, fastForwardBtn, fasterFastForwardBtn, incVolBtn, decVolBtn, rewindBtn, fasterRewindBtn);


            top.Add(win, upperMenu);
            Application.Run();
        }
    }
}
