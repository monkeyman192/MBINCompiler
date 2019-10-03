using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0x2AB2A0C204802FD9, NameHash = 0xEB5EF017837D2565)]
    public class GcMissionConditionIsScanEventOnCurrentPlanet : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Event;
        public bool AllowInShip;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
