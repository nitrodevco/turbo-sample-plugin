using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Camera;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Camera;

internal class RequestCameraConfigurationMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new RequestCameraConfigurationMessage();
}
