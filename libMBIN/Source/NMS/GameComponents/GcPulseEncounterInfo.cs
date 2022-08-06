using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5123CDA4AAF4C50A, NameHash = 0x657592AF71342449)]
    public class GcPulseEncounterInfo : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Id;
        /* 0x010 */ public NMSString0x20A MarkerLabel;
        /* 0x030 */ public NMSString0x20A ChatMessageName;
        /* 0x050 */ public TkTextureResource MarkerIcon;
        /* 0x0D8 */ public NMSString0x20A CustomNotify;
        /* 0x0F8 */ public NMSString0x20A CustomNotifyTitle;
        /* 0x118 */ public NMSString0x20A CustomNotifyOSD;
        /* 0x138 */ public bool UseMarkerIconInOSD;
        /* 0x140 */ public GcPulseEncounterSpawnConditions SpawnConditions;
        /* 0x1A0 */ public float SpawnChance;
        /* 0x1A4 */ public float SpawnDistance;
        /* 0x1A8 */ public GcAudioWwiseEvents AudioEvent;
        /* 0x1AC */ public bool Silent;
        /* 0x1B0 */ public NMSTemplate Encounter;
    }
}
