using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcTriggerActionComponentData : NMSTemplate
    {
        public bool HideModel;
        public bool StartInactive;
        public List<GcActionTriggerState> States;
        public bool Persistent;
        [NMS(Size = 7, Ignore = true)]
        public byte[] Padding19;
        public NMSString0x10 PersistentState;
    }
}
