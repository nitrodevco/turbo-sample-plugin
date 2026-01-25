using Turbo.Primitives.Messages.Incoming.Userdefinedroomevents;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Userdefinedroomevents;

internal class ApplySnapshotMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new ApplySnapshotMessage { Id = packet.PopInt() };
}
