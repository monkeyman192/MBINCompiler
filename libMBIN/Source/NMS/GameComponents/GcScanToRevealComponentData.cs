using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6D874C8B6B678DBE, NameHash = 0x3CE9B038B094EDFF)]
    public class GcScanToRevealComponentData : NMSTemplate
    {
        [NMS(Index = 13)]
        /* 0x00 */ public NMSString0x10 LockedMarkerScanOverride;
        [NMS(Index = 10)]
        /* 0x10 */ public NMSString0x10 OnRevealEffect;
        [NMS(Index = 3)]
        /* 0x20 */ public NMSString0x10 RequiredTech;
        [NMS(Index = 8)]
        /* 0x30 */ public float DissolveTime;
        // size: 0x3
        public enum HideScanMarkerConditionEnum : uint {
            Never,
            MissingTech,
            Hidden,
        }
        [NMS(Index = 14)]
        /* 0x34 */ public HideScanMarkerConditionEnum HideScanMarkerCondition;
        [NMS(Index = 5)]
        /* 0x38 */ public float MaxRange;
        [NMS(Index = 4)]
        /* 0x3C */ public GcStatsTypes RequiredStat;
        [NMS(Index = 6)]
        /* 0x40 */ public float RevealTime;
        [NMS(Index = 7)]
        /* 0x44 */ public bool DoDissolve;
        [NMS(Index = 12)]
        /* 0x45 */ public bool LockedMarkerClearOnReveal;
        [NMS(Index = 11)]
        /* 0x46 */ public bool OnRevealEffectScaleWithAABB;
        [NMS(Index = 2)]
        /* 0x47 */ public bool RevealedByShipScan;
        [NMS(Index = 1)]
        /* 0x48 */ public bool RevealedByToolScan;
        [NMS(Index = 9)]
        /* 0x49 */ public bool SetNodeActivation;
        [NMS(Index = 0)]
        /* 0x4A */ public bool StartEnabled;
    }
}
