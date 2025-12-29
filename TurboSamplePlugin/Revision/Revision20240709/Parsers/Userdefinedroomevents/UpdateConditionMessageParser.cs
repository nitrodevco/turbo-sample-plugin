using System;
using System.Collections.Generic;
using Turbo.Primitives.Messages.Incoming.Userdefinedroomevents;
using Turbo.Primitives.Packets;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Userdefinedroomevents.Data;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Userdefinedroomevents;

internal class UpdateConditionMessageParser : UpdateWiredDataParser, IParser
{
    public override List<object> GetRequiredDefinitionSpecifics() => [1];

    public override List<object> GetRequiredTypeSpecifics() => [(byte)1, true];

    public override Type UpdateMessageType => typeof(UpdateConditionMessage);
}
