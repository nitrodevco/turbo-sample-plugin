using System.Collections.Generic;
using Turbo.Primitives.Messages.Incoming.Userdefinedroomevents.Wiredmenu;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Userdefinedroomevents.Wiredmenu;

internal class WiredGetAllVariablesDiffsMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet)
    {
        var variables = new List<(long Id, int Hash)>();
        var count = packet.PopInt();

        while (count > 0)
        {
            variables.Add((packet.PopLong(), packet.PopInt()));

            count--;
        }

        return new WiredGetAllVariablesDiffsMessage { VariableHashes = variables };
    }
}
