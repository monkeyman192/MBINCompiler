namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x15D26A60973A874A, NameHash = 0x8F2EED19BC2FFF5D)]
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
