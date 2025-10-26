﻿using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Navigator;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Navigator;

internal class FavouritesMessageSerializer(int header)
    : AbstractSerializer<FavouritesMessage>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        FavouritesMessage message
    )
    {
        //
    }
}
