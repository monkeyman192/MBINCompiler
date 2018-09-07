namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x4)]
    public class GcMissionConditionInCombat : NMSTemplate
    {
		public enum CombatTypeEnum { GroundCombat, SpaceCombat }
		public CombatTypeEnum CombatType;
    }
}
