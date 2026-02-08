using Turbo.Primitives.Messages.Outgoing.Users;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Users.Data;

internal class GuildInfoSerializer
{
    public static void Serialize(IServerPacket packet, GuildInfo guild)
    {
        packet.WriteInteger(guild.GroupId);
        packet.WriteString(guild.GroupName);
        packet.WriteString(guild.BadgeCode);
        packet.WriteString(guild.PrimaryColor);
        packet.WriteString(guild.SecondaryColor);
        packet.WriteBoolean(guild.Favourite);
        packet.WriteInteger(guild.OwnerId);
        packet.WriteBoolean(guild.HasForum);
    }
}
