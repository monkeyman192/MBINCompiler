namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x792A5B0DEA01629E, NameHash = 0xE9C6B201)]
    public class GcAccessibleOverride_Text : NMSTemplate
    {
        // size: 0x1
        public enum AccessibleOverride_TextEnum : uint {
            FontHeight,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public AccessibleOverride_TextEnum AccessibleOverride_Text;
        [NMS(Index = 1)]
        /* 0x4 */ public float FloatValue;
    }
}
