using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB1E0E8AFA4A55904, NameHash = 0xBEE7641A87849DA4)]
    public class GcGoToStateAction : NMSTemplate
    {
        public NMSString0x10 State;
        public bool Broadcast;
		public enum BroadcastLevelEnum { Scene, LocalModel, Local }
		public BroadcastLevelEnum BroadcastLevel;
    }
}
