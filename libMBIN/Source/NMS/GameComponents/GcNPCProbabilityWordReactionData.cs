using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xFD3E06F73583E90B, NameHash = 0xE83E88B1C1909A3F)]
    public class GcNPCProbabilityWordReactionData : NMSTemplate
    {
        public NMSString0x20A NextInteraction;
        public float Probability;
    }
}
