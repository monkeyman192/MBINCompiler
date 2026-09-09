using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x327CA4409901A071, NameHash = 0x191B9BEB)]
    public class GcPulseEncounterInfo : NMSTemplate
    {
        [NMS(Index = 15)]
        /* 0x000 */ public Colour CustomNotifyColour;
        [NMS(Index = 17)]
        /* 0x010 */ public GcPulseEncounterSpawnConditions SpawnConditions;
        [NMS(Index = 2)]
        /* 0x080 */ public NMSString0x20A ChatMessageName;
        [NMS(Index = 11)]
        /* 0x0A0 */ public NMSString0x20A CustomNotify;
        [NMS(Index = 13)]
        /* 0x0C0 */ public NMSString0x20A CustomNotifyOSD;
        [NMS(Index = 12)]
        /* 0x0E0 */ public NMSString0x20A CustomNotifyTitle;
        [NMS(Index = 1)]
        /* 0x100 */ public NMSString0x20A MarkerLabel;
        [NMS(Index = 3)]
        /* 0x120 */ public TkTextureResource MarkerIcon;
        [NMS(Index = 22)]
        /* 0x138 */ public NMSTemplate Encounter;
        [NMS(Index = 0)]
        /* 0x148 */ public NMSString0x10 Id;
        [NMS(Index = 6)]
        /* 0x158 */ public NMSString0x10 MarkerRequiresMissionActive;
        [NMS(Index = 5)]
        /* 0x168 */ public NMSString0x10 MarkerRequiresMissionComplete;
        [NMS(Index = 9)]
        /* 0x178 */ public NMSString0x10 MarkerRequiresMissionNotActive;
        [NMS(Index = 8)]
        /* 0x188 */ public NMSString0x10 MarkerRequiresMissionNotComplete;
        [NMS(Index = 10)]
        /* 0x198 */ public NMSString0x10 MarkerRequiresMissionNotSelected;
        [NMS(Index = 7)]
        /* 0x1A8 */ public NMSString0x10 MarkerRequiresMissionSelected;
        [NMS(Index = 20)]
        /* 0x1B8 */ public GcAudioWwiseEvents AudioEvent;
        [NMS(Index = 18)]
        /* 0x1BC */ public float SpawnChance;
        [NMS(Index = 19)]
        /* 0x1C0 */ public float SpawnDistance;
        [NMS(Index = 14)]
        /* 0x1C4 */ public bool HasColourOverride;
        [NMS(Index = 4)]
        /* 0x1C5 */ public bool MarkerAlwaysShows;
        [NMS(Index = 21)]
        /* 0x1C6 */ public bool Silent;
        [NMS(Index = 16)]
        /* 0x1C7 */ public bool UseMarkerIconInOSD;
    }
}
