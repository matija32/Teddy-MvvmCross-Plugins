﻿using System;

namespace Teddy.MvvmCross.Plugins.SimpleAudioPlayer
{
    public interface IMvxSimpleAudioPlayer : IDisposable
    {
        /// <summary>
        /// Gets the current audio path.
        /// </summary>
        string Path { get;}

        /// <summary>
        /// Gets the duration of the audio.
        /// </summary>
        double Duration { get; }

        /// <summary>
        /// Plays a specified audio path.
        /// 
        /// The following formats of path are supported:
        ///     - Absolute URL, 
        ///       e.g. http://abc.com/test.mp3
        ///       
        ///     - Assets Deployed with App, relative path assumed to be in the device specific assets folder
        ///       Android and UWP relative to the Assets folder while iOS relative to the App root folder
        ///       e.g. test.mp3
        ///       
        ///     - Local File System, arbitry local absolute file path the app has access
        ///       e.g. /sdcard/test.mp3
        /// </summary>
        /// <param name="path">
        ///     The audio path.
        /// </param>
        bool Open(string path);

        /// <summary>
        /// Plays the opened audio.
        /// </summary>
        void Play();

        /// <summary>
        /// Stops playing.
        /// </summary>
        void Stop();

        /// <summary>
        /// Pauses the playing.
        /// </summary>
        void Pause();

        /// <summary>
        /// Seeks to specified position in milliseconds.
        /// </summary>
        /// <param name="pos">The position to seek to.</param>
        void Seek(double pos);
    }
}
