﻿using System;
using System.Windows;

namespace TheatrePlayMusicController
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            songController1.MusicSource = new Uri("Resources/Songs/BarMusic.m4a", UriKind.Relative);
            songController2.MusicSource = new Uri(
                "Resources/Songs/CarelessWhisper.mp3",
                UriKind.Relative
            );
            songController3.MusicSource = new Uri(
                "Resources/Songs/PhoneRingtone.mp3",
                UriKind.Relative
            );

            songController1.SongName = "Bar Music";
            songController2.SongName = "Careless Whisper";
            songController3.SongName = "Phone Ringtone";
        }
    }
}
