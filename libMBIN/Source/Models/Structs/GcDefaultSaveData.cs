namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x103C0)]
    public class GcDefaultSaveData : NMSTemplate
    {
        /* 0x00000 */ public GcPlayerStateData State;
        /* 0x10340 */ public GcPlayerSpawnStateData Spawn;
    }
}
