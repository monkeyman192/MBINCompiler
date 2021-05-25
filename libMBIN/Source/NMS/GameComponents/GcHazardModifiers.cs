using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0xF0AEE7807366ABE, NameHash = 0x8D86E8499B88B845)]
    public class GcHazardModifiers : NMSTemplate
    {
        // size: 0x5
		public enum HazardModifierEnum { Temperature, Toxicity, Radiation, LifeSupportDrain, Gravity }
		public HazardModifierEnum HazardModifier;
    }
}