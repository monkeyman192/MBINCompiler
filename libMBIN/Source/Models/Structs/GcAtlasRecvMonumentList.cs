namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x1A0)]
    public class GcAtlasRecvMonumentList : NMSTemplate
    {
        public ulong ClientUserdata;
        public int NumberOfThings;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] PaddingC;
        public GcAtlasMonument Mounments;
    }
}
