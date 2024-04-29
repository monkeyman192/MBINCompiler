namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3A8EB966251AA804, NameHash = 0x140DDCF57268A02D)]
    public class GcVROverride_Text : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public float FloatValue;
        [NMS(Index = 1)]
        /* 0x4 */ public int IntValue;
        // size: 0x2
        public enum VROverride_TextEnum : uint {
            FontHeight,
            FontIndex,
        }
        [NMS(Index = 0)]
        /* 0x8 */ public VROverride_TextEnum VROverride_Text;
    }
}
