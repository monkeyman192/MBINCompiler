using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xBCE880E6CBE6D9EC, NameHash = 0x3DD2820ADB22F4BF)]
    public class GcRealitySubstanceCraftingMix : NMSTemplate // 0x18 bytes
    {
        [NMS(Size = 0x10)]
        public string ID;

        public int Ratio;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
