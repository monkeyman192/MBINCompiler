namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x15D26A60973A874A, NameHash = 0x8D8A3097)]
    public class GcCreatureRoleFrequencyModifier : NMSTemplate
    {
        // size: 0x4
        public enum CreatureRoleFrequencyModifierEnum : uint {
            Never,
            Low,
            Normal,
            High,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CreatureRoleFrequencyModifierEnum CreatureRoleFrequencyModifier;
    }
}
