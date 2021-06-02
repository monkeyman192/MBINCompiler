using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x9D0E732B5D903457, NameHash = 0x3CB08423D3A469E6)]
    public class GcBuildingBlueprint : NMSTemplate
    {
        public NMSString0x10 ProductID;
        public int GroupId;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
