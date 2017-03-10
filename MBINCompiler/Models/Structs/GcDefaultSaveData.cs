namespace MBINCompiler.Models.Structs
{
    public class GcDefaultSaveData : NMSTemplate
    {
        /* 0x00000 */ public GcPlayerStateData State;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0x3B1C8 */ public byte[] Padding3B1C8;

        /* 0x3B1D0 */
        public GcPlayerSpawnStateData Spawn;
    }
}
