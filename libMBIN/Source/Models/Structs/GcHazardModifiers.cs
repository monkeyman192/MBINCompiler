namespace libMBIN.Models.Structs
{
    public class GcHazardModifiers : NMSTemplate
    {
		public enum HazardModifierEnum { Temperature, Toxicity, Radiation, LifeSupportDrain }
		public HazardModifierEnum HazardModifier;
    }
}
