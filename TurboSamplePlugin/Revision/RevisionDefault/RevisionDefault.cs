using System;
using System.Collections.Generic;
using Turbo.Primitives.Networking.Revisions;
using Turbo.Primitives.Packets;
using TurboSamplePlugin.Revision.RevisionDefault.Parsers.Handshake;

namespace TurboSamplePlugin.Revision.RevisionDefault;

public class RevisionDefault : IRevision
{
    public string Revision => "Default";

    public IDictionary<int, IParser> Parsers { get; } =
        new Dictionary<int, IParser>
        {
            { (int)MessageEvent.ClientHelloMessageEvent, new ClientHelloParser() },
        };

    public IDictionary<Type, ISerializer> Serializers { get; } =
        new Dictionary<Type, ISerializer> { };
}
