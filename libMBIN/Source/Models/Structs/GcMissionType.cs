namespace libMBIN.Models.Structs
{
    public class GcMissionType : NMSTemplate
    {
        public int MissionType;
        public string[] MissionTypeValues()
        {
            return new[] { "SpaceCombat", "GroundCombat", "Research", "MissingPerson", "Repair", "Cargo", "Piracy", "Photo", "Feeding" };
        }
    }
}
