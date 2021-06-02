using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0xF28FCA1E3D439CD9, NameHash = 0x3F92E065272FE2A9)]
    public class GcCreatureGroupDescription : NMSTemplate       // size: 0x20
    {
        public NMSString0x10 Group;
        public int MinGroupSize;                // 1
        public int MaxGroupSize;                // 3
        public float GroupsPerSquareKm;         // 41200000h
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}