namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x4)]
    public class GcMissionConditionInCombat : NMSTemplate
    {
        public int CombatType;
        public string[] CombatTypeValues()
        {
            return new[] { "GroundCombat", "SpaceCombat"};
        }
    }
}
