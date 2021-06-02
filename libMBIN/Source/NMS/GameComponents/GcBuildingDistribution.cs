using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x401D8256EF89A26A, NameHash = 0xF28B5D3A889453A9)]
    public class GcBuildingDistribution : NMSTemplate // size: 0x18 bytes
    {
        public NMSString0x10 Name;
        public int MinDistance;
        public int MaxDistance;
    }
}