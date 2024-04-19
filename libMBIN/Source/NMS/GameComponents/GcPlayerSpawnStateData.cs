namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC0D8ABF2503E00DC, NameHash = 0x6F8C3831DC1540EC)]
    public class GcPlayerSpawnStateData : NMSTemplate
    {
        /* 0x00 */ public Vector4f AbandonedFreighterPositionInSystem;
        /* 0x10 */ public Vector4f AbandonedFreighterTransformAt;
        /* 0x20 */ public Vector4f AbandonedFreighterTransformUp;
        /* 0x30 */ public Vector4f FreighterPositionInSystem;
        /* 0x40 */ public Vector4f FreighterTransformAt;
        /* 0x50 */ public Vector4f FreighterTransformUp;
        /* 0x60 */ public Vector4f PlayerDeathRespawnPositionInSystem;
        /* 0x70 */ public Vector4f PlayerDeathRespawnTransformAt;
        /* 0x80 */ public Vector4f PlayerPositionInSystem;
        /* 0x90 */ public Vector4f PlayerTransformAt;
        /* 0xA0 */ public Vector4f ShipPositionInSystem;
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
        /* 0xC0 */ public LastKnownPlayerStateEnum LastKnownPlayerState;
    }
}
