namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB70922B5EDADE5C9, NameHash = 0xFB3432A11716EF87)]
    public class GcHologramState : NMSTemplate
    {
        // size: 0x4
        public enum HologramStateEnum : uint {
            Hologram,
            Attract,
            Explode,
            Disabled,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public HologramStateEnum HologramState;
    }
}
