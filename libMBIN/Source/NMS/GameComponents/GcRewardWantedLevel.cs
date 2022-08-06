using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x20A0105001737A1E, NameHash = 0x206FB3EB76163BEA)]
    public class GcRewardWantedLevel : NMSTemplate
    {
        public NMSString0x20A Message;
        public int Level;
    }
}