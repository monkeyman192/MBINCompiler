namespace MBINCompiler.Models.Structs
{
    public class GcSeed : NMSTemplate   // size = 0x10
    {
        /* 0x00 */ public long Seed;
        /* 0x08 */ public bool UseSeedValue;
        
        [NMS(Size = 7, Ignore = true)]
        /* 0x09 */ public byte[] Padding9; // todo: is this always here? might be padding inside the parent template instead
    }
}
