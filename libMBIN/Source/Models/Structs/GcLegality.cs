namespace libMBIN.Models.Structs
{
    public class GcLegality : NMSTemplate
    {

		public enum LegalityEnum { Legal, Illegal, None }
		public LegalityEnum Legality;
    }
}
