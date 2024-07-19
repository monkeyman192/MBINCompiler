namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA96E4896558B51C1, NameHash = 0xE1F664A6)]
    public class GcPlayerSpawnStateData : NMSTemplate
    {
        [NMS(Index = 10)]
        /* 0x00 */ public Vector4f AbandonedFreighterPositionInSystem;
        [NMS(Index = 11)]
        /* 0x10 */ public Vector4f AbandonedFreighterTransformAt;
        [NMS(Index = 12)]
        /* 0x20 */ public Vector4f AbandonedFreighterTransformUp;
        [NMS(Index = 7)]
        /* 0x30 */ public Vector4f FreighterPositionInSystem;
        [NMS(Index = 8)]
        /* 0x40 */ public Vector4f FreighterTransformAt;
        [NMS(Index = 9)]
        /* 0x50 */ public Vector4f FreighterTransformUp;
        [NMS(Index = 2)]
        /* 0x60 */ public Vector4f PlayerDeathRespawnPositionInSystem;
        [NMS(Index = 3)]
        /* 0x70 */ public Vector4f PlayerDeathRespawnTransformAt;
        [NMS(Index = 0)]
        /* 0x80 */ public Vector4f PlayerPositionInSystem;
        [NMS(Index = 1)]
        /* 0x90 */ public Vector4f PlayerTransformAt;
        [NMS(Index = 4)]
        /* 0xA0 */ public Vector4f ShipPositionInSystem;
        [NMS(Index = 5)]
        /* 0xB0 */ public Vector4f ShipTransformAt;
        // size: 0x7
        public enum LastKnownPlayerStateEnum : uint {
            OnFoot,
            InShip,
            InStation,
            AboardFleet,
            InNexus,
            AbandonedFreighter,
            InShipLanded,
        }
        [NMS(Index = 6)]
        /* 0xC0 */ public LastKnownPlayerStateEnum LastKnownPlayerState;
    }
}
