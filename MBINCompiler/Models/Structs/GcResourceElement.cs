namespace MBINCompiler.Models.Structs
{
    public class GcResourceElement : NMSTemplate // size = 0x2A8
    {
        [NMS(Size = 0x80)]
        /* 0x00 */ public string Filename;

        [NMS(Size = 8, Ignore = true)]
        /* 0x80 */ public byte[] Padding80;

        /* 0x88 */ public GcSeed Seed;

        [NMS(Size = 0x200)]
        /* 0x98 */ public string AltId;

        /* 0x298 */ public TkProceduralTextureChosenOptionList ProceduralTexture;
    }
}
