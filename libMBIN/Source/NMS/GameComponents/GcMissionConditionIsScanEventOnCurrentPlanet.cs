using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0x79C865AEDFE0C003, NameHash = 0xEB5EF017837D2565)]
    public class GcMissionConditionIsScanEventOnCurrentPlanet : NMSTemplate
    {
        public NMSString0x20 Event;
        public bool AllowInShip;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
