using Turbo.Contracts.Abstractions;
using Turbo.Contracts.Enums.Navigator;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Preferences;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Preferences;

internal class SetNewNavigatorWindowPreferencesMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new SetNewNavigatorWindowPreferencesMessage
        {
            X = packet.PopInt(),
            Y = packet.PopInt(),
            Width = packet.PopInt(),
            Height = packet.PopInt(),
            OpenSavedSearches = packet.PopBoolean(),
            ResultsMode = (NavigatorResultsMode)packet.PopInt(),
        };
}
