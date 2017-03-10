namespace MBINCompiler.Models.Structs
{
    public class GcUniqueNPCSpawnData : NMSTemplate // 0x2C8 bytes
    {
        public int NPCSpawnCondition;
        public string[] NPCSpawnConditionValues()
        {
            return new[] { "Always", "MiniStation" };
        }

        [NMS(Size = 4, Ignore = true)]
        /* 0x08 */ public byte[] pad8;

        [NMS(Size = 0x10)]
        public string ID;
        public GcResourceElement ResourceElement;

        public GcAlienRace Race;
        [NMS(Size = 4, Ignore = true)]
        /* 0x08 */
        public byte[] pad4;

    }
}
