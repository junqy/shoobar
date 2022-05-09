
namespace WindowsFormsApp1
{
    partial class Shoobar
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shoobar));
            this.music_prog_bar = new System.Windows.Forms.ProgressBar();
            this.track_list = new System.Windows.Forms.ListBox();
            this.tracklength_lbl = new System.Windows.Forms.Label();
            this.currlength_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.volume_bar = new System.Windows.Forms.TrackBar();
            this.song_lbl = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.load_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rewind_btn = new System.Windows.Forms.Button();
            this.forward_btn = new System.Windows.Forms.Button();
            this.open_btn = new System.Windows.Forms.Button();
            this.prev_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.pause_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.play_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.volume_bar)).BeginInit();
            this.SuspendLayout();
            // 
            // music_prog_bar
            // 
            this.music_prog_bar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(122)))), ((int)(((byte)(214)))));
            this.music_prog_bar.Location = new System.Drawing.Point(57, 383);
            this.music_prog_bar.Name = "music_prog_bar";
            this.music_prog_bar.Size = new System.Drawing.Size(686, 10);
            this.music_prog_bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.music_prog_bar.TabIndex = 5;
            this.music_prog_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.music_prog_bar_MouseDown);
            // 
            // track_list
            // 
            this.track_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(81)))), ((int)(((byte)(140)))));
            this.track_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.track_list.Font = new System.Drawing.Font("Nunito", 9F);
            this.track_list.ForeColor = System.Drawing.Color.White;
            this.track_list.FormattingEnabled = true;
            this.track_list.ItemHeight = 17;
            this.track_list.Location = new System.Drawing.Point(15, 130);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(773, 238);
            this.track_list.TabIndex = 6;
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
            // 
            // tracklength_lbl
            // 
            this.tracklength_lbl.AutoSize = true;
            this.tracklength_lbl.Font = new System.Drawing.Font("Nunito", 9F);
            this.tracklength_lbl.ForeColor = System.Drawing.Color.White;
            this.tracklength_lbl.Location = new System.Drawing.Point(750, 379);
            this.tracklength_lbl.Name = "tracklength_lbl";
            this.tracklength_lbl.Size = new System.Drawing.Size(39, 17);
            this.tracklength_lbl.TabIndex = 12;
            this.tracklength_lbl.Text = "00:00";
            // 
            // currlength_lbl
            // 
            this.currlength_lbl.AutoSize = true;
            this.currlength_lbl.Font = new System.Drawing.Font("Nunito", 9F);
            this.currlength_lbl.ForeColor = System.Drawing.Color.White;
            this.currlength_lbl.Location = new System.Drawing.Point(12, 379);
            this.currlength_lbl.Name = "currlength_lbl";
            this.currlength_lbl.Size = new System.Drawing.Size(39, 17);
            this.currlength_lbl.TabIndex = 13;
            this.currlength_lbl.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // volume_bar
            // 
            this.volume_bar.Cursor = System.Windows.Forms.Cursors.Default;
            this.volume_bar.Location = new System.Drawing.Point(689, 409);
            this.volume_bar.Name = "volume_bar";
            this.volume_bar.Size = new System.Drawing.Size(99, 45);
            this.volume_bar.TabIndex = 14;
            this.volume_bar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volume_bar.Scroll += new System.EventHandler(this.volume_bar_Scroll);
            // 
            // song_lbl
            // 
            this.song_lbl.AutoSize = true;
            this.song_lbl.Font = new System.Drawing.Font("Nunito", 9F);
            this.song_lbl.Location = new System.Drawing.Point(12, 413);
            this.song_lbl.Name = "song_lbl";
            this.song_lbl.Size = new System.Drawing.Size(0, 17);
            this.song_lbl.TabIndex = 16;
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.save_btn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.save;
            this.save_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Nunito", 12F);
            this.save_btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.save_btn.Location = new System.Drawing.Point(665, 85);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(37, 37);
            this.save_btn.TabIndex = 19;
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // load_btn
            // 
            this.load_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.load_btn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.load;
            this.load_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.load_btn.FlatAppearance.BorderSize = 0;
            this.load_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load_btn.Font = new System.Drawing.Font("Nunito", 12F);
            this.load_btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.load_btn.Location = new System.Drawing.Point(708, 85);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(37, 37);
            this.load_btn.TabIndex = 18;
            this.load_btn.UseVisualStyleBackColor = false;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.shoobar;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(15, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 113);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.volume;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(660, 401);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(37, 37);
            this.panel1.TabIndex = 15;
            // 
            // rewind_btn
            // 
            this.rewind_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.rewind_btn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.rewind;
            this.rewind_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rewind_btn.FlatAppearance.BorderSize = 0;
            this.rewind_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rewind_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rewind_btn.Location = new System.Drawing.Point(294, 401);
            this.rewind_btn.Name = "rewind_btn";
            this.rewind_btn.Size = new System.Drawing.Size(37, 37);
            this.rewind_btn.TabIndex = 9;
            this.rewind_btn.UseVisualStyleBackColor = false;
            this.rewind_btn.Click += new System.EventHandler(this.rewind_btn_Click);
            // 
            // forward_btn
            // 
            this.forward_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.forward_btn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.forward;
            this.forward_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.forward_btn.FlatAppearance.BorderSize = 0;
            this.forward_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forward_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.forward_btn.Location = new System.Drawing.Point(466, 401);
            this.forward_btn.Name = "forward_btn";
            this.forward_btn.Size = new System.Drawing.Size(37, 37);
            this.forward_btn.TabIndex = 8;
            this.forward_btn.UseVisualStyleBackColor = false;
            this.forward_btn.Click += new System.EventHandler(this.forward_btn_Click);
            // 
            // open_btn
            // 
            this.open_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.open_btn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.folder;
            this.open_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.open_btn.FlatAppearance.BorderSize = 0;
            this.open_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_btn.Font = new System.Drawing.Font("Nunito", 12F);
            this.open_btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.open_btn.Location = new System.Drawing.Point(751, 85);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(37, 37);
            this.open_btn.TabIndex = 7;
            this.open_btn.UseVisualStyleBackColor = false;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // prev_btn
            // 
            this.prev_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.prev_btn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.previous;
            this.prev_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.prev_btn.FlatAppearance.BorderSize = 0;
            this.prev_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prev_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.prev_btn.Location = new System.Drawing.Point(251, 401);
            this.prev_btn.Name = "prev_btn";
            this.prev_btn.Size = new System.Drawing.Size(37, 37);
            this.prev_btn.TabIndex = 4;
            this.prev_btn.UseVisualStyleBackColor = false;
            this.prev_btn.Click += new System.EventHandler(this.prev_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.next_btn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.next;
            this.next_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.next_btn.FlatAppearance.BorderSize = 0;
            this.next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.next_btn.Location = new System.Drawing.Point(509, 401);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(37, 37);
            this.next_btn.TabIndex = 3;
            this.next_btn.UseVisualStyleBackColor = false;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // pause_btn
            // 
            this.pause_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.pause_btn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.pause;
            this.pause_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pause_btn.FlatAppearance.BorderSize = 0;
            this.pause_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pause_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pause_btn.Location = new System.Drawing.Point(337, 401);
            this.pause_btn.Name = "pause_btn";
            this.pause_btn.Size = new System.Drawing.Size(37, 37);
            this.pause_btn.TabIndex = 2;
            this.pause_btn.UseVisualStyleBackColor = false;
            this.pause_btn.Click += new System.EventHandler(this.pause_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.stop_btn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.stop;
            this.stop_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stop_btn.FlatAppearance.BorderSize = 0;
            this.stop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stop_btn.Location = new System.Drawing.Point(423, 401);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(37, 37);
            this.stop_btn.TabIndex = 1;
            this.stop_btn.UseVisualStyleBackColor = false;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // play_btn
            // 
            this.play_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.play_btn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.play;
            this.play_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.play_btn.FlatAppearance.BorderSize = 0;
            this.play_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.play_btn.Location = new System.Drawing.Point(380, 401);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(37, 37);
            this.play_btn.TabIndex = 0;
            this.play_btn.UseVisualStyleBackColor = false;
            this.play_btn.Click += new System.EventHandler(this.play_btn_Click);
            // 
            // Shoobar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.load_btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.song_lbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.currlength_lbl);
            this.Controls.Add(this.tracklength_lbl);
            this.Controls.Add(this.rewind_btn);
            this.Controls.Add(this.forward_btn);
            this.Controls.Add(this.open_btn);
            this.Controls.Add(this.track_list);
            this.Controls.Add(this.music_prog_bar);
            this.Controls.Add(this.prev_btn);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.pause_btn);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.play_btn);
            this.Controls.Add(this.volume_bar);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Shoobar";
            this.Text = "Shoobar";
            ((System.ComponentModel.ISupportInitialize)(this.volume_bar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button play_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button pause_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Button prev_btn;
        private System.Windows.Forms.ProgressBar music_prog_bar;
        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.Button forward_btn;
        private System.Windows.Forms.Button rewind_btn;
        private System.Windows.Forms.Label tracklength_lbl;
        private System.Windows.Forms.Label currlength_lbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar volume_bar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label song_lbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.Button save_btn;
    }
}

