﻿namespace TubumuMeeting.Meeting.Server
{
    public class RoomPeer
    {
        public Room Room { get; set; }

        public Peer Peer { get; set; }

        public RoomPeer(Room room, Peer peer)
        {
            Room = room;
            Peer = peer;
        }
    }
}