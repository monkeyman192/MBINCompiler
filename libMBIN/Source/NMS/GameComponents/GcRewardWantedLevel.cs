using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x20A0105001737A1E, NameHash = 0x206FB3EB76163BEA)]
    public class GcRewardWantedLevel : NMSTemplate      // size: 0x28
    {
        [NMS(Size = 0x20)]
        public string Message;
        public int Level;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
