namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8FDB3630AB843ADE, NameHash = 0x4638E9B4)]
    public class GcWonderType : NMSTemplate
    {
        // size: 0x7
        public enum WonderTypeEnum : uint {
            Treasure,
            WeirdBasePart,
            Planet,
            Creature,
            Flora,
            Mineral,
            Custom,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public WonderTypeEnum WonderType;
    }
}
