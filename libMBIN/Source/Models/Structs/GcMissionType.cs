namespace libMBIN.Models.Structs
{
    public class GcMissionType : NMSTemplate
    {
		public enum MissionTypeEnum { SpaceCombat, GroundCombat, Research, MissingPerson, Repair, Cargo, Piracy, Photo, Feeding }
		public MissionTypeEnum MissionType;
    }
}
