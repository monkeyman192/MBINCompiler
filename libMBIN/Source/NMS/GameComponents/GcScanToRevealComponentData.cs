using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4CD90FA870A7C9F7, NameHash = 0x6C0235EC)]
    public class GcScanToRevealComponentData : NMSTemplate
    {
        [NMS(Index = 14)]
        /* 0x00 */ public NMSString0x10 LockedMarkerScanOverride;
        [NMS(Index = 11)]
        /* 0x10 */ public NMSString0x10 OnRevealEffect;
        [NMS(Index = 4)]
        /* 0x20 */ public NMSString0x10 RequiredTech;
        [NMS(Index = 9)]
        /* 0x30 */ public float DissolveTime;
        // size: 0x3
        public enum HideScanMarkerConditionEnum : uint {
            Never,
            MissingTech,
            Hidden,
        }
        [NMS(Index = 15)]
        /* 0x34 */ public HideScanMarkerConditionEnum HideScanMarkerCondition;
        [NMS(Index = 6)]
        /* 0x38 */ public float MaxRange;
        [NMS(Index = 5)]
        /* 0x3C */ public GcStatsTypes RequiredStat;
        [NMS(Index = 7)]
        /* 0x40 */ public float RevealTime;
        [NMS(Index = 8)]
        /* 0x44 */ public bool DoDissolve;
        [NMS(Index = 1)]
        /* 0x45 */ public bool EnabledOnlyOnAbandonedNexus;
        [NMS(Index = 13)]
        /* 0x46 */ public bool LockedMarkerClearOnReveal;
        [NMS(Index = 12)]
        /* 0x47 */ public bool OnRevealEffectScaleWithAABB;
        [NMS(Index = 3)]
        /* 0x48 */ public bool RevealedByShipScan;
        [NMS(Index = 2)]
        /* 0x49 */ public bool RevealedByToolScan;
        [NMS(Index = 10)]
        /* 0x4A */ public bool SetNodeActivation;
        [NMS(Index = 0)]
        /* 0x4B */ public bool StartEnabled;
    }
}
