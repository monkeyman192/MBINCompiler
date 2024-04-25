namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x389DCB7F89EAC210, NameHash = 0x39B4070AE5C76F6F)]
    public class GcAntagonistGroup : NMSTemplate
    {
        // size: 0x6
        public enum AntagonistGroupEnum : uint {
            Player,
            Fiends,
            Creatures,
            Sentinels,
            Turrets,
            Walls,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public AntagonistGroupEnum AntagonistGroup;
    }
}
