using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x198, GUID = 0x0, NameHash = 0x657592AF71342449)]
    public class GcPulseEncounterInfo : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Id;
        [NMS(Size = 0x20)]
        /* 0x010 */ public string MarkerLabel;
        [NMS(Size = 0x20)]
        /* 0x030 */ public string ChatMessageName;
        /* 0x050 */ public TkTextureResource MarkerIcon;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0D4 */ public byte[] PaddingD4;
        /* 0x0D8 */ public GcPulseEncounterSpawnConditions SpawnConditions;
        /* 0x138 */ public float SpawnChance;
        /* 0x13C */ public float SpawnDistance;
        /* 0x140 */ public GcAudioWwiseEvents AudioEvent;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x144 */ public byte[] Padding144;
        /* 0x148 */ public NMSTemplate Encounter;
    }
}
