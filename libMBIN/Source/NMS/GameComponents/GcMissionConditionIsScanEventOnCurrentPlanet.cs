using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x79C865AEDFE0C003, NameHash = 0xEB5EF017837D2565)]
    public class GcMissionConditionIsScanEventOnCurrentPlanet : NMSTemplate
    {
        public NMSString0x20A Event;
        public bool AllowInShip;
    }
}
