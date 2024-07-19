namespace libMBIN.NMS {

    [NMS(Size = 0x18)]
    public class HashedString : NMSTemplate
    {
        public ulong Offset;
        public uint Length;
        public uint Padding0xC;
        public uint Hash;
        public uint Padding0x14;
    }
}
