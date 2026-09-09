namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD0D3FE4F654FC380, NameHash = 0x99900E77)]
    public class GcRewardScanEvent : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Event;
        [NMS(Index = 8)]
        /* 0x20 */ public NMSString0x20A FailureOSD;
        // size: 0x6
        public enum ScanEventTableEnum : uint {
            Space,
            Planet,
            Missions,
            Tutorial,
            MissionsCreative,
            NPCPlanetSite,
        }
        [NMS(Index = 1)]
        /* 0x40 */ public ScanEventTableEnum ScanEventTable;
        [NMS(Index = 4)]
        /* 0x44 */ public float StartDelay;
        [NMS(Index = 2)]
        /* 0x48 */ public bool DoAerialScan;
        [NMS(Index = 6)]
        /* 0x49 */ public bool ForceSilentFailure;
        [NMS(Index = 7)]
        /* 0x4A */ public bool RevealPOIIfRevelant;
        [NMS(Index = 3)]
        /* 0x4B */ public bool UseMissionIDSeedForEvent;
        [NMS(Index = 5)]
        /* 0x4C */ public bool UseStartDelayWhenNoAerialScan;
    }
}
