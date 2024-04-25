namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF353736FC3B7065, NameHash = 0xCC36FE8AD202DF8)]
    public class GcCombatEffectType : NMSTemplate
    {
        // size: 0x4
        public enum CombatEffectTypeEnum : uint {
            None,
            Fire,
            Stun,
            Slow,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CombatEffectTypeEnum CombatEffectType;
    }
}
