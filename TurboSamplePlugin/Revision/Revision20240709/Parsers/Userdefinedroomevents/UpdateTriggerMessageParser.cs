using System.Collections.Generic;
using Turbo.Primitives.Messages.Incoming.Userdefinedroomevents;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Userdefinedroomevents;

internal class UpdateTriggerMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet)
    {
        var id = packet.PopInt();
        var intParams = new List<int>();
        var stuffIds = new List<int>();
        var furniSources = new List<int>();
        var userSources = new List<int>();
        var variableIds = new List<int>();

        var intCount = packet.PopInt();

        if (intCount > 0)
        {
            while (intCount > 0)
            {
                intParams.Add(packet.PopInt());

                intCount--;
            }
        }

        var stringParam = packet.PopString();

        var stuffIdCount = packet.PopInt();

        if (stuffIdCount > 0)
        {
            while (stuffIdCount > 0)
            {
                stuffIds.Add(packet.PopInt());

                stuffIdCount--;
            }
        }

        var furniSourceCount = packet.PopInt();

        if (furniSourceCount > 0)
        {
            while (furniSourceCount > 0)
            {
                furniSources.Add(packet.PopInt());

                furniSourceCount--;
            }
        }

        var userSourceCount = packet.PopInt();

        if (userSourceCount > 0)
        {
            while (userSourceCount > 0)
            {
                userSources.Add(packet.PopInt());

                userSourceCount--;
            }
        }

        var variableIdCount = packet.PopInt();

        if (variableIdCount > 0)
        {
            while (variableIdCount > 0)
            {
                variableIds.Add(packet.PopInt());

                variableIdCount--;
            }
        }

        return new UpdateTriggerMessage
        {
            Id = id,
            IntParams = intParams,
            VariableIds = variableIds,
            StringParam = stringParam,
            StuffIds = stuffIds,
            FurniSources = furniSources,
            PlayerSources = userSources,
        };
    }
}
