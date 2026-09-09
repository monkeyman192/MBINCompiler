using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9471F166F0FA4DE2, NameHash = 0x6C0235EC)]
    public class GcScanToRevealComponentData : NMSTemplate
    {
        [NMS(Index = 15)]
        /* 0x00 */ public NMSString0x10 LockedMarkerScanOverride;
        [NMS(Index = 12)]
        /* 0x10 */ public NMSString0x10 OnRevealEffect;
        [NMS(Index = 4)]
        /* 0x20 */ public NMSString0x10 RequiredTech;
        [NMS(Index = 11)]
        /* 0x30 */ public NMSString0x10 RevealOnMission;
        [NMS(Index = 9)]
        /* 0x40 */ public float DissolveTime;
        // size: 0x3
        public enum HideScanMarkerConditionEnum : uint {
            Never,
            MissingTech,
            Hidden,
        }
        [NMS(Index = 16)]
        /* 0x44 */ public HideScanMarkerConditionEnum HideScanMarkerCondition;
        [NMS(Index = 6)]
        /* 0x48 */ public float MaxRange;
        [NMS(Index = 5)]
        /* 0x4C */ public GcStatsTypes RequiredStat;
        [NMS(Index = 7)]
        /* 0x50 */ public float RevealTime;
        [NMS(Index = 8)]
        /* 0x54 */ public bool DoDissolve;
        [NMS(Index = 1)]
        /* 0x55 */ public bool EnabledOnlyOnAbandonedNexus;
        [NMS(Index = 14)]
        /* 0x56 */ public bool LockedMarkerClearOnReveal;
        [NMS(Index = 13)]
        /* 0x57 */ public bool OnRevealEffectScaleWithAABB;
        [NMS(Index = 3)]
        /* 0x58 */ public bool RevealedByShipScan;
        [NMS(Index = 2)]
        /* 0x59 */ public bool RevealedByToolScan;
        [NMS(Index = 10)]
        /* 0x5A */ public bool SetNodeActivation;
        [NMS(Index = 0)]
        /* 0x5B */ public bool StartEnabled;
    }
}
