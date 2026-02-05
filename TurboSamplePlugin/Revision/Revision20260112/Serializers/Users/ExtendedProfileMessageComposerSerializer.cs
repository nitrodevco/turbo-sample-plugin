using Turbo.Primitives.Messages.Outgoing.Users;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Users;

internal class ExtendedProfileMessageComposerSerializer(int header)
    : AbstractSerializer<ExtendedProfileMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, ExtendedProfileMessageComposer message)
    {
        packet.WriteInteger(message.UserId);
        packet.WriteString(message.UserName);
        packet.WriteString(message.Figure);
        packet.WriteString(message.Motto);
        packet.WriteString(message.CreationDate);
        packet.WriteInteger(message.AchievementScore);
        packet.WriteInteger(message.FriendCount);
        packet.WriteBoolean(message.IsFriend);
        packet.WriteBoolean(message.IsFriendRequestSent);
        packet.WriteBoolean(message.IsOnline);
        
        // Guild count and guild data
        packet.WriteInteger(message.Guilds.Count);
        foreach (var guild in message.Guilds)
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
        
        packet.WriteInteger(message.LastAccessSinceInSeconds);
        packet.WriteBoolean(message.OpenProfileWindow);
        packet.WriteBoolean(message.IsHidden);
        packet.WriteInteger(message.AccountLevel);
        packet.WriteInteger(message.IntegerField24);
        packet.WriteInteger(message.StarGemCount);
        packet.WriteBoolean(message.BooleanField26);
        packet.WriteBoolean(message.BooleanField27);
    }
}
