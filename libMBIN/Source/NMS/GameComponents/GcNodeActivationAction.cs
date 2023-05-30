using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcNodeActivationAction : NMSTemplate
    {
        public int NodeActiveState;
        public string[] NodeActiveStateValues()
        {
            return new[] { "Activate", "Deactivate", "Toggle" };
        }

        public NMSString0x80 Name;
    }
}
