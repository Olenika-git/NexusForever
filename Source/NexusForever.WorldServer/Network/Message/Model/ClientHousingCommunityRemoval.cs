﻿using NexusForever.Shared.Network;
using NexusForever.Shared.Network.Message;
using NexusForever.WorldServer.Network.Message.Model.Shared;

namespace NexusForever.WorldServer.Network.Message.Model
{
    [Message(GameMessageOpcode.ClientHousingCommunityRemoval)]
    public class ClientHousingCommunityRemoval : IReadable
    {
        public TargetResidence TargetResidence { get; private set; }

        public void Read(GamePacketReader reader)
        {
            TargetResidence = new TargetResidence();
            TargetResidence.Read(reader);
        }
    }
}
