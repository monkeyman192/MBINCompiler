using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8FDBA424CB55A384, NameHash = 0xC52227A9653C40A8)]
    public class GcMissionConditionInVR : NMSTemplate
    {
        public bool NeedsHandControllers;
        public bool NeedsSnapTurnOn;
        public bool NeedsNoHandControllers;
        public bool NeedsTeleportOn;
        public bool NeedsSmoothMoveOn;
    }
}
