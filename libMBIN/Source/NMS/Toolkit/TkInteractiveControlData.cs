using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xCE2D0D8381C37963, NameHash = 0xF6987FC027F7291)]
    public class TkInteractiveControlData : NMSTemplate
    {
        public NMSString0x20 Id;
        public NMSString0x10 RewardId;
        public float Cooldown;
    }
}
