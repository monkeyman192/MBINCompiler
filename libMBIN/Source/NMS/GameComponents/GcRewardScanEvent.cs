namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC6C01260FE2B261, NameHash = 0xD6D2BF5DDCCD9F49)]
    public class GcRewardScanEvent : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Event;
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
        /* 0x40 */ public ScanEventTableEnum ScanEventTable;
        /* 0x44 */ public float StartDelay;
        /* 0x48 */ public bool DoAerialScan;
        /* 0x49 */ public bool ForceSilentFailure;
        /* 0x4A */ public bool UseMissionSeedForEvent;
        /* 0x4B */ public bool UseStartDelayWhenNoAerialScan;
    }
}
