using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCB180B958BDCF67, NameHash = 0xF0829DCD8555A52E)]
    public class GcDefaultSaveData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00000 */ public GcPlayerStateData State;
        [NMS(Index = 1)]
        /* 0x748D0 */ public GcPlayerSpawnStateData Spawn;
    }
}
