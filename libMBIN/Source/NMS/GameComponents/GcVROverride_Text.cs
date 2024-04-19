namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x96C21BF25C430F0A, NameHash = 0x140DDCF57268A02D)]
    public class GcVROverride_Text : NMSTemplate
    {
        /* 0x0 */ public float FloatValue;
        /* 0x4 */ public int IntValue;
        // size: 0x2
        public enum VROverride_TextEnum : uint {
            FontHeight,
            FontIndex,
        }
        /* 0x8 */ public VROverride_TextEnum VROverride_Text;
    }
}
