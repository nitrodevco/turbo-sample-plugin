using System;
using Turbo.Primitives.Furniture.Enums;
using Turbo.Primitives.Inventory.Snapshots;
using Turbo.Primitives.Packets;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Engine.Data;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Inventory.Furni.Data;

internal class FurnitureFloorItemSerializer
{
    public static void Serialize(IServerPacket packet, FurnitureFloorItemSnapshot item)
    {
        packet
            .WriteInteger(-Math.Abs(item.ItemId))
            .WriteString(item.ProductType.ToLegacyString().ToUpper()) // item type
            .WriteInteger(item.ItemId)
            .WriteInteger(item.SpriteId)
            .WriteInteger((int)item.FurniCategory);

        StuffDataSnapshotSerializer.Serialize(packet, item.StuffData);

        packet
            .WriteBoolean(item.CanRecycle)
            .WriteBoolean(item.CanTrade)
            .WriteBoolean(item.CanGroup)
            .WriteBoolean(item.CanSell)
            .WriteInteger(item.SecondsToExpiration)
            .WriteBoolean(item.HasRentPeriodStarted)
            .WriteInteger(item.RoomId);

        if (item.ProductType == ProductType.Floor)
            packet.WriteString(string.Empty).WriteInteger(0);
    }
}
