using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8, GUID = 0x4CFC57AEE31F9054, NameHash = 0x651F2A30D5D1F1A1)]
    public class GcTerrainEdit : NMSTemplate
    {
        public byte Data;
        public int Position;
    }
}
