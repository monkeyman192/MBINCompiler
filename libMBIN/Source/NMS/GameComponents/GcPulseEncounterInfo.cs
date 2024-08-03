using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBD35976D5F755F28, NameHash = 0x191B9BEB)]
    public class GcPulseEncounterInfo : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x000 */ public GcPulseEncounterSpawnConditions SpawnConditions;
        [NMS(Index = 2)]
        /* 0x060 */ public NMSString0x20A ChatMessageName;
        [NMS(Index = 4)]
        /* 0x080 */ public NMSString0x20A CustomNotify;
        [NMS(Index = 6)]
        /* 0x0A0 */ public NMSString0x20A CustomNotifyOSD;
        [NMS(Index = 5)]
        /* 0x0C0 */ public NMSString0x20A CustomNotifyTitle;
        [NMS(Index = 1)]
        /* 0x0E0 */ public NMSString0x20A MarkerLabel;
        [NMS(Index = 3)]
        /* 0x100 */ public TkTextureResource MarkerIcon;
        [NMS(Index = 13)]
        /* 0x118 */ public NMSTemplate Encounter;
        [NMS(Index = 0)]
        /* 0x128 */ public NMSString0x10 Id;
        [NMS(Index = 11)]
        /* 0x138 */ public GcAudioWwiseEvents AudioEvent;
        [NMS(Index = 9)]
        /* 0x13C */ public float SpawnChance;
        [NMS(Index = 10)]
        /* 0x140 */ public float SpawnDistance;
        [NMS(Index = 12)]
        /* 0x144 */ public bool Silent;
        [NMS(Index = 7)]
        /* 0x145 */ public bool UseMarkerIconInOSD;
    }
}
