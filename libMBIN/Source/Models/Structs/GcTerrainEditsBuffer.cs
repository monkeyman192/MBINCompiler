namespace libMBIN.Models.Structs
{
    [NMS(Size = 0xAAC0)]
    public class GcTerrainEditsBuffer : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x0000 */ public ulong[] GalacticAddresses;
        [NMS(Size = 0x80)]
        /* 0x0400 */ public int[] BufferSizes;
        [NMS(Size = 0x80)]
        /* 0x0600 */ public byte[] BufferAges;
        [NMS(Size = 0x80)]
        /* 0x0680 */ public Vector4f[] BufferAnchors;
        [NMS(Size = 0x1388)]
        /* 0x0E80 */ public GcTerrainEdit[] Edits;
    }
}
