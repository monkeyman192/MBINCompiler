namespace MBINCompiler.Models.Structs
{
    public class GcResourceElement : NMSTemplate // size = 0x2A8
    {
        [NMS(Size = 0x80)]
        /* 0x00 */ public string Filename;

        /* 0x80 */
        [NMS(Size = 8, Ignore = true)]
        public byte[] PreSeedPad80;

        // Exploding GcSeed Struct
        /* 0x88 */
        public long Seed;
        /* 0x90 */
        public bool UseSeedValue;

        /* 0x91 */
        [NMS(Size = 7, Ignore = true)]
        public byte[] PreSeedPad91;
        [NMS(Size = 0x200)]
        public string AltId;

        [NMS(Size = 0x10, Ignore = true)]
        public byte[] skip;
        //public TkProceduralTextureChosenOptionList Texture;
    }
}
