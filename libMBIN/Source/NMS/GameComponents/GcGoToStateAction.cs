using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcGoToStateAction : NMSTemplate
    {
        public NMSString0x10 State;

        public bool Broadcast;
        public int BroadcastLevel;
        public string[] BroadcastLevelValues()
        {
            return new[] { "Scene", "LocalModel" };
        }
    }
}
