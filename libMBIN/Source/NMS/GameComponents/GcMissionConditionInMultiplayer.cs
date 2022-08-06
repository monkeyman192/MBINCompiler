using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x862D7990AD850507, NameHash = 0x36A2416CDA700331)]
    public class GcMissionConditionInMultiplayer : NMSTemplate
    {
        public bool MustBeInFireteam;
    }
}
