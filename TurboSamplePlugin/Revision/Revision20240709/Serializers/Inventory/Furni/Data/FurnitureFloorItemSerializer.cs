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
            .WriteString(ProductType.Floor.ToLegacyString().ToUpper())
            .WriteInteger(item.ItemId)
            .WriteInteger(item.SpriteId)
            .WriteInteger((int)item.Definition.FurniCategory);

        StuffDataSnapshotSerializer.Serialize(packet, item.StuffData);

        packet
            .WriteBoolean(item.Definition.CanRecycle)
            .WriteBoolean(item.Definition.CanTrade)
            .WriteBoolean(item.Definition.CanGroup)
            .WriteBoolean(item.Definition.CanSell)
            .WriteInteger(item.SecondsToExpiration)
            .WriteBoolean(item.HasRentPeriodStarted)
            .WriteInteger(item.RoomId)
            .WriteString(item.SlotId)
            .WriteInteger(item.Extra);
    }
}
