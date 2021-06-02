using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0xF701652DA9F900D6, NameHash = 0xCBC6E3739F0132B0)]
    public class GcBuildingCostPartCount : NMSTemplate
    {
        public NMSString0x10 Id;
        public int Count;

        [NMS( Size = 0x04, Ignore = true )]
        public byte[] Padding14;
    }
}