using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1A8, GUID = 0x20982378EF686841, NameHash = 0xB3C5F69D62F6CA73)]
    public class GcMissionSequenceGetToExpedition : NMSTemplate
    {
        public NMSString0x80 Message;
        public NMSString0x80 GalaxyMapMessage;
        public NMSString0x20 Event;
        public float CompletionDistance;
        public NMSString0x80 DebugText;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
