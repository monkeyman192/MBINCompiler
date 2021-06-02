using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0xB1E0E8AFA4A55904, Alignment = 0x8, NameHash = 0xBEE7641A87849DA4)]
    public class GcGoToStateAction : NMSTemplate
    {
        public NMSString0x10 State;
        public bool Broadcast;
		public enum BroadcastLevelEnum { Scene, LocalModel, Local }
		public BroadcastLevelEnum BroadcastLevel;
    }
}
