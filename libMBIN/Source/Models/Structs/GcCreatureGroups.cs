namespace libMBIN.Models.Structs
{
    public class GcCreatureGroups : NMSTemplate
    {
		public enum CreatureGroupEnum { Solo, Couple, Group, Herd }
		public CreatureGroupEnum CreatureGroup;
    }
}
