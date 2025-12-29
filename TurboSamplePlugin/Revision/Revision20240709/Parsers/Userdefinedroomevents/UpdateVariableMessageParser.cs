using System;
using Turbo.Primitives.Messages.Incoming.Userdefinedroomevents;
using Turbo.Primitives.Packets;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Userdefinedroomevents.Data;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Userdefinedroomevents;

internal class UpdateVariableMessageParser : UpdateWiredDataParser, IParser
{
    public override Type UpdateMessageType => typeof(UpdateVariableMessage);
}
