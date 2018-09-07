namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x24AD0)]
    public class GcDefaultSaveData : NMSTemplate
    {
        /* 0x00000 */ public GcPlayerStateData State;
        /* 0x24A50 */ public GcPlayerSpawnStateData Spawn;
    }
}
