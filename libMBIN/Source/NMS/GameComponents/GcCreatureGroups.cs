namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA69F70739493EEEE, NameHash = 0xDC6AC60910C16B2D)]
    public class GcCreatureGroups : NMSTemplate
    {
        // size: 0x4
        public enum CreatureGroupEnum : uint {
            Solo,
            Couple,
            Group,
            Herd,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CreatureGroupEnum CreatureGroup;
    }
}
