using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6D874C8B6B678DBE, NameHash = 0x3CE9B038B094EDFF)]
    public class GcScanToRevealComponentData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 LockedMarkerScanOverride;
        /* 0x10 */ public NMSString0x10 OnRevealEffect;
        /* 0x20 */ public NMSString0x10 RequiredTech;
        /* 0x30 */ public float DissolveTime;
        // size: 0x3
        public enum HideScanMarkerConditionEnum : uint {
            Never,
            MissingTech,
            Hidden,
        }
        /* 0x34 */ public HideScanMarkerConditionEnum HideScanMarkerCondition;
        /* 0x38 */ public float MaxRange;
        /* 0x3C */ public GcStatsTypes RequiredStat;
        /* 0x40 */ public float RevealTime;
        /* 0x44 */ public bool DoDissolve;
        /* 0x45 */ public bool LockedMarkerClearOnReveal;
        /* 0x46 */ public bool OnRevealEffectScaleWithAABB;
        /* 0x47 */ public bool RevealedByShipScan;
        /* 0x48 */ public bool RevealedByToolScan;
        /* 0x49 */ public bool SetNodeActivation;
        /* 0x4A */ public bool StartEnabled;
    }
}
