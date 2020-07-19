using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x178, GUID = 0x452767AA53EA123D, NameHash = 0x657592AF71342449)]
    public class GcPulseEncounterInfo : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Id;
        [NMS(Size = 0x20)]
        /* 0x010 */ public string MarkerLabel;
        /* 0x030 */ public TkTextureResource MarkerIcon;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0B4 */ public byte[] PaddingB4;
        /* 0x0B8 */ public GcPulseEncounterSpawnConditions SpawnCondition;
        /* 0x118 */ public float SpawnChance;
        /* 0x11C */ public float SpawnDistance;
        /* 0x120 */ public GcAudioWwiseEvents AudioEvent;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x124 */ public byte[] Padding24;
        /* 0x128 */ public NMSTemplate Encounter;
    }
}
