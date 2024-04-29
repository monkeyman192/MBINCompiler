using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA8481F7C7DD8C697, NameHash = 0xB82C2871716786E2)]
    public class GcUniqueNPCSpawnData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public GcResourceElement ResourceElement;
        [NMS(Index = 0)]
        /* 0x2A8 */ public NMSString0x10 Id;
        [NMS(Index = 1)]
        /* 0x2B8 */ public NMSString0x10 PresetId;
        [NMS(Index = 4)]
        /* 0x2C8 */ public GcAlienRace Race;
        [NMS(Index = 3)]
        /* 0x2CC */ public float Scale;
    }
}
