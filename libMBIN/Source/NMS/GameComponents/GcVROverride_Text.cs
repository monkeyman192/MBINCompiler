using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC, GUID = 0x5324CD047EF9FCBA, NameHash = 0x140DDCF57268A02D)]
    public class GcVROverride_Text : NMSTemplate
    {
        public enum VROverride_TextEnum { FontHeight, FontIndex }
        public VROverride_TextEnum VROverride_Text;
        public int IntValue;
        public float FloatValue;
    }
}
