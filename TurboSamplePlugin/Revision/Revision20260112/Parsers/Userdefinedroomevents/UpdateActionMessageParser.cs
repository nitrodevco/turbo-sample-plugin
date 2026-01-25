using System;
using System.Collections.Generic;
using Turbo.Primitives.Messages.Incoming.Userdefinedroomevents;
using Turbo.Primitives.Packets;
using TurboSamplePlugin.Revision.Revision20260112.Parsers.Userdefinedroomevents.Data;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Userdefinedroomevents;

internal class UpdateActionMessageParser : UpdateWiredDataParser, IParser
{
    public override List<object> GetRequiredDefinitionSpecifics() => [1];

    public override Type UpdateMessageType => typeof(UpdateActionMessage);
}
