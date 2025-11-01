﻿using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Navigator;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Navigator;

internal class ConvertedRoomIdMessageComposerSerializer(int header)
    : AbstractSerializer<ConvertedRoomIdMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, ConvertedRoomIdMessageComposer message)
    {
        packet.WriteString(message.GlobalId).WriteInteger(message.ConvertedId);
    }
}
