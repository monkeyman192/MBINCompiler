using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5468AF544643F24A, NameHash = 0xF989045F)]
    public class GcDefaultSaveData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00000 */ public GcPlayerStateData State;
        [NMS(Index = 1)]
        /* 0x6E700 */ public GcPlayerSpawnStateData Spawn;
    }
}
