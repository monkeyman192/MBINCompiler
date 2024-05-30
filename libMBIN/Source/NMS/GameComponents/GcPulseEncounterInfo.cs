using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xED67BCC5F35B56C8, NameHash = 0x657592AF71342449)]
    public class GcPulseEncounterInfo : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x000 */ public GcPulseEncounterSpawnConditions SpawnConditions;
        [NMS(Index = 13)]
        /* 0x060 */ public NMSTemplate Encounter;
        [NMS(Index = 2)]
        /* 0x0B0 */ public NMSString0x20A ChatMessageName;
        [NMS(Index = 4)]
        /* 0x0D0 */ public NMSString0x20A CustomNotify;
        [NMS(Index = 6)]
        /* 0x0F0 */ public NMSString0x20A CustomNotifyOSD;
        [NMS(Index = 5)]
        /* 0x110 */ public NMSString0x20A CustomNotifyTitle;
        [NMS(Index = 1)]
        /* 0x130 */ public NMSString0x20A MarkerLabel;
        [NMS(Index = 0)]
        /* 0x150 */ public NMSString0x10 Id;
        [NMS(Index = 3)]
        /* 0x160 */ public TkTextureResource MarkerIcon;
        [NMS(Index = 11)]
        /* 0x1E4 */ public GcAudioWwiseEvents AudioEvent;
        [NMS(Index = 9)]
        /* 0x1E8 */ public float SpawnChance;
        [NMS(Index = 10)]
        /* 0x1EC */ public float SpawnDistance;
        [NMS(Index = 12)]
        /* 0x1F0 */ public bool Silent;
        [NMS(Index = 7)]
        /* 0x1F1 */ public bool UseMarkerIconInOSD;
    }
}
