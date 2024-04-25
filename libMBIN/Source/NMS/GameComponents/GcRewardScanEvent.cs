namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC6C01260FE2B261, NameHash = 0xD6D2BF5DDCCD9F49)]
    public class GcRewardScanEvent : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Event;
        [NMS(Index = 7)]
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
        [NMS(Index = 3)]
        /* 0x4A */ public bool UseMissionSeedForEvent;
        [NMS(Index = 5)]
        /* 0x4B */ public bool UseStartDelayWhenNoAerialScan;
    }
}
