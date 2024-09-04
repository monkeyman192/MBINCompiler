using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB8B43398628511B1, NameHash = 0xF989045F)]
    public class GcDefaultSaveData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00000 */ public GcPlayerStateData State;
        [NMS(Index = 1)]
        /* 0x702E0 */ public GcPlayerSpawnStateData Spawn;
    }
}
