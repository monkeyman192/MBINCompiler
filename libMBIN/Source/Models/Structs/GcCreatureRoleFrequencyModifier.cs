namespace libMBIN.Models.Structs
{
    public class GcCreatureRoleFrequencyModifier : NMSTemplate
    {
	  public int CreatureRoleFrequencyModifier;
	  public string[] CreatureRoleFrequencyModifierValues()
        {
            return new[] { "Never", "Low", "Normal", "High" };
        }
    }
}
