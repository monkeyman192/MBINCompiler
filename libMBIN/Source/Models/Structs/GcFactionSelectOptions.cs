namespace libMBIN.Models.Structs
{
    public class GcFactionSelectOptions : NMSTemplate
    {
		public enum FactionOptionEnum { DataDefined, CurrentMission, CurrentSystem }
		public FactionOptionEnum FactionOption;
        public GcMissionFaction Faction;
    }
}
