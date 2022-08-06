using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4E27A612337C1ECA, NameHash = 0x24A11989AE4D41A1)]
    public class GcMissionConditionIsScanEventLocal : NMSTemplate
    {
        public NMSString0x20A Event;
        public bool RequiresFullFireteam;
    }
}
