﻿using System.Collections.Generic;
using Hubbl.Core.Model;

namespace Hubbl.Core.Service
{
	public interface IMusicPlayer
    {

		PlaylistEntry QueueTrack (HubblUser user, Track track);

		PlaylistEntry CurrentPlayedEntry { get; set; }
		List<PlaylistEntry> Playlist { get; set; }
        ServerStatus Status { get; set; }
        
        void LikeTrack (HubblUser user, int entryId);
		void DislikeTrack (HubblUser user, int entryId);

	    void SetVolume(int volume);
		

		void Play ();
		void Stop ();
	    bool Stoped();

        void Pause ();
	    bool Paused();
    }
}
