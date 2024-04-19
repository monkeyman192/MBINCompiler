using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x53383A0D00E0B187, NameHash = 0x657592AF71342449)]
    public class GcPulseEncounterInfo : NMSTemplate
    {
        /* 0x000 */ public GcPulseEncounterSpawnConditions SpawnConditions;
        /* 0x060 */ public NMSTemplate Encounter;
        /* 0x0B0 */ public NMSString0x20A ChatMessageName;
        /* 0x0D0 */ public NMSString0x20A CustomNotify;
        /* 0x0F0 */ public NMSString0x20A CustomNotifyOSD;
        /* 0x110 */ public NMSString0x20A CustomNotifyTitle;
        /* 0x130 */ public NMSString0x20A MarkerLabel;
        /* 0x150 */ public NMSString0x10 Id;
        /* 0x160 */ public TkTextureResource MarkerIcon;
        /* 0x1E4 */ public GcAudioWwiseEvents AudioEvent;
        /* 0x1E8 */ public float SpawnChance;
        /* 0x1EC */ public float SpawnDistance;
        /* 0x1F0 */ public bool Silent;
        /* 0x1F1 */ public bool UseMarkerIconInOSD;
    }
}
