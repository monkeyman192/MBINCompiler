namespace libMBIN.Models.Structs
{
    public class GcHazardModifiers : NMSTemplate
    {
        public int HazardModifier;
        public string[] HazardModifierValues()
        {
            return new[] { "Temperature", "Toxicity", "Radiation", "LifeSupportDrain"};
        }
    }
}
