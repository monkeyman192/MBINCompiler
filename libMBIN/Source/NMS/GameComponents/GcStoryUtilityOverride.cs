using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0x89968B9F613A0032, NameHash = 0xE1C7E19E0F5C0C48)]
    public class GcStoryUtilityOverride : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Name;
        [NMS(Size = 0x10)]
        public string Reward;
    }
}
