﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)
using OpenNos.Core;

namespace OpenNos.GameObject
{
    [PacketHeader("walk")]
    public class WalkPacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public short XCoordinate { get; set; }

        [PacketIndex(1)]
        public short YCoordinate { get; set; }

        [PacketIndex(2)]
        public short Unknown { get; set; }

        [PacketIndex(3)]
        public short Speed { get; set; }

        #endregion
    }
}