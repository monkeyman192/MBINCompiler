using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0xFD3E06F73583E90B, NameHash = 0xE83E88B1C1909A3F)]
    public class GcNPCProbabilityWordReactionData : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string NextInteraction;
        public float Probability;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
