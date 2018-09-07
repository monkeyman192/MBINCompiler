namespace libMBIN.Models.Structs
{
    public class TkLSystemRestrictionData : NMSTemplate
    {
        public int Amount;
		public enum RestrictionEnum { NoMoreThan, AtLeast, AtLeastIfICan }
		public RestrictionEnum Restriction;
    }
}
