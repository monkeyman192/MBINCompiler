using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x443D162EBDC71FCE, NameHash = 0x2FCD6845)]
    public class GcUniqueNPCSpawnData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public GcResourceElement ResourceElement;
        [NMS(Index = 0)]
        /* 0x48 */ public NMSString0x10 Id;
        [NMS(Index = 1)]
        /* 0x58 */ public NMSString0x10 PresetId;
        [NMS(Index = 4)]
        /* 0x68 */ public GcAlienRace Race;
        [NMS(Index = 3)]
        /* 0x6C */ public float Scale;
    }
}
