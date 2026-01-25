using System;
using Turbo.Primitives.Messages.Incoming.Userdefinedroomevents;
using Turbo.Primitives.Packets;
using TurboSamplePlugin.Revision.Revision20260112.Parsers.Userdefinedroomevents.Data;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Userdefinedroomevents;

internal class UpdateTriggerMessageParser : UpdateWiredDataParser, IParser
{
    public override Type UpdateMessageType => typeof(UpdateTriggerMessage);
}
