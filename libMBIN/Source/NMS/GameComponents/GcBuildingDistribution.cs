using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x401D8256EF89A26A, NameHash = 0xF28B5D3A889453A9)]
    public class GcBuildingDistribution : NMSTemplate
    {
        public NMSString0x10 Name;
        public int MinDistance;
        public int MaxDistance;
    }
}