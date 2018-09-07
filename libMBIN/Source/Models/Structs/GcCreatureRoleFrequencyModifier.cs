namespace libMBIN.Models.Structs
{
    public class GcCreatureRoleFrequencyModifier : NMSTemplate
    {
		public enum CreatureRoleFrequencyModifierEnum { Never, Low, Normal, High }
		public CreatureRoleFrequencyModifierEnum CreatureRoleFrequencyModifier;
    }
}
