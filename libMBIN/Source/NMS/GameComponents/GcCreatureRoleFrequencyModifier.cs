using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xC7A12F4728E8043, NameHash = 0x8F2EED19BC2FFF5D)]
    public class GcCreatureRoleFrequencyModifier : NMSTemplate
    {
		public enum CreatureRoleFrequencyModifierEnum { Never, Low, Normal, High }
		public CreatureRoleFrequencyModifierEnum CreatureRoleFrequencyModifier;
    }
}
