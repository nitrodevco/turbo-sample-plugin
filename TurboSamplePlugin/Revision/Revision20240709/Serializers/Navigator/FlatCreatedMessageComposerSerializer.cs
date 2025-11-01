﻿using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Navigator;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Navigator;

internal class FlatCreatedMessageComposerSerializer(int header)
    : AbstractSerializer<FlatCreatedMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, FlatCreatedMessageComposer message)
    {
        packet.WriteInteger(message.RoomId).WriteString(message.Name);
    }
}
