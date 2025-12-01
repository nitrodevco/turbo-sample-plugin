using Turbo.Primitives.Messages.Incoming.Camera;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Camera;

internal class PublishPhotoMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new PublishPhotoMessage();
}
