﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)
using OpenNos.Core;

namespace OpenNos.GameObject.Packets.ServerPackets
{
    [PacketHeader("wear")]
    public class WearjPacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public byte Inventory { get; set; }

        [PacketIndex(1)]
        public byte InventorySlot { get; set; }

        #endregion
    }
}
