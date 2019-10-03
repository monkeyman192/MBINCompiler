using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xD990F68BA08865C7, NameHash = 0xDE7AA917D5163592)]
    public class GcNPCSeatedPosture : NMSTemplate
    {
        public enum NPCSeatedPostureEnum { Sofa, Sit }
        public NPCSeatedPostureEnum NPCSeatedPosture;
    }
}
