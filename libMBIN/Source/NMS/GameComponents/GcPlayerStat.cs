using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xB9146AAAE645DEC, NameHash = 0x386029983CBEF506)]
    public class GcPlayerStat : NMSTemplate // 0x20 bytes
    {
        [NMS(Size = 0x10)]
        public string Id;

        public GcStatValueData Value;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding1C;
    }
}
