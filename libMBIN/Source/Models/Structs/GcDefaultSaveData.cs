namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x10300)]
    public class GcDefaultSaveData : NMSTemplate
    {
        /* 0x00000 */ public GcPlayerStateData State;
        /* 0x10280 */ public GcPlayerSpawnStateData Spawn;
    }
}
